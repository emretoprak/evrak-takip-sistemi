using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Native;
using ETS.Akislar.Enums;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class YeniGelenGidenArsivle : Form
    {
        private readonly long _id;
        private readonly EvrakTip _evrakTip;

        /// <summary>
        /// Initial işlemler
        /// </summary>
        /// <param name="id">Arşivlenecek Evrak ID</param>
        /// <param name="evrakTip">Arşivlenecek Evrak Tipi</param>
        public YeniGelenGidenArsivle(long id, EvrakTip evrakTip)
        {
            _id = id;
            _evrakTip = evrakTip;
            InitializeComponent();
            SetEvrakiCikaranMakamlar();
            SetGizlilikDerecesi();
            SetSubeler();
            SetBirimler();

            using (var db = new ETSEntities())
            {
                switch (_evrakTip)
                {
                    case EvrakTip.GelenEvrak:
                    {
                        var gelenEvrak = db.GelenEvrak.SingleOrDefault(s => s.Id == _id);
                        if (gelenEvrak != null)
                        {
                            txtIlgiliEvrak.Text = gelenEvrak.EvrakKayitNo.ToString(CultureInfo.InvariantCulture);
                            txtEvrakiCikaranMakam.EditValue = gelenEvrak.EvrakiCikaranMakamId;
                            txtGizlilikDerecesi.EditValue = gelenEvrak.GizlilikDerecesiId;
                            txtAraSayiNo.Text = gelenEvrak.EvrakKayitNo.ToString(CultureInfo.InvariantCulture);
                            txtKonusu.Text = gelenEvrak.DosyaNoKonusu;
                        }
                        else
                        {
                            XtraMessageBox.Show("Kayıt bulumadı");
                            Close();
                        }

                    }
                        break;
                    case EvrakTip.GidenEvrak:
                    {
                        var gidenEvrak = db.GidenEvrak.SingleOrDefault(s => s.Id == _id);
                        if (gidenEvrak != null)
                        {
                            txtIlgiliEvrak.Text = gidenEvrak.EvrakKayitNo.ToString(CultureInfo.InvariantCulture);
                            txtEvrakiCikaranMakam.EditValue = gidenEvrak.EvrakiCikaranMakamId;
                            txtGizlilikDerecesi.EditValue = gidenEvrak.GizlilikDerecesiId;
                        }
                        else
                        {
                            XtraMessageBox.Show("Kayıt bulumadı");
                            Close();
                        }
                    }
                        break;
                }
            }
        }

        /// <summary>
        /// Evrakı çıkaran makamlar listesi
        /// </summary>
        private void SetEvrakiCikaranMakamlar()
        {
            txtEvrakiCikaranMakam.Properties.Columns.Clear();
            txtEvrakiCikaranMakam.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Makam",
                Caption = "Makam"
            });
            txtEvrakiCikaranMakam.Properties.DisplayMember = "Makam";
            txtEvrakiCikaranMakam.Properties.ValueMember = "Id";
            txtEvrakiCikaranMakam.Properties.DataSource = new ETSEntities().EvrakiCikaranMakam.ToList();
        }

        /// <summary>
        /// Gizilik derecesi listesi
        /// </summary>
        private void SetGizlilikDerecesi()
        {
            txtGizlilikDerecesi.Properties.Columns.Clear();
            txtGizlilikDerecesi.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Derece",
                Caption = "Derece"
            });
            txtGizlilikDerecesi.Properties.DisplayMember = "Derece";
            txtGizlilikDerecesi.Properties.ValueMember = "Id";
            txtGizlilikDerecesi.Properties.DataSource = new ETSEntities().GizlilikDerecesi.ToList();
        }

        /// <summary>
        /// Şubeler listesi
        /// </summary>
        private void SetSubeler()
        {
            txtSube.Properties.Columns.Clear();
            txtSube.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Sube",
                Caption = "Sube"
            });
            txtSube.Properties.DisplayMember = "Sube";
            txtSube.Properties.ValueMember = "Id";
            txtSube.Properties.DataSource = new ETSEntities().Subeler.ToList();
        }

        /// <summary>
        /// Birimler listesi
        /// </summary>
        private void SetBirimler()
        {
            txtIlgiliBirim.Properties.Columns.Clear();
            txtIlgiliBirim.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Birim",
                Caption = "Birim"
            });
            txtIlgiliBirim.Properties.DisplayMember = "Birim";
            txtIlgiliBirim.Properties.ValueMember = "Id";
            txtIlgiliBirim.Properties.DataSource = new ETSEntities().Birimler.ToList();
        }

        /// <summary>
        /// Yeni evrakı çıkaran makam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEvrakiCikaranMakam_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            using (var db = new ETSEntities())
            {
                db.EvrakiCikaranMakam.Add(new EvrakiCikaranMakam
                {
                    Makam = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }

            SetEvrakiCikaranMakamlar();
            e.Handled = true;
        }

        /// <summary>
        /// Yeni gizlilik derecesi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGizlilikDerecesi_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null) return;
            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            using (var db = new ETSEntities())
            {
                db.GizlilikDerecesi.Add(new GizlilikDerecesi
                {
                    Derece = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }
            SetGizlilikDerecesi();
            e.Handled = true;
        }

        /// <summary>
        /// Yeni şube
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSube_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            using (var db = new ETSEntities())
            {
                db.Subeler.Add(new Subeler
                {
                    Sube = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }
            SetSubeler();
            e.Handled = true;
        }

        /// <summary>
        /// Yeni ilgili birim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIlgiliBirim_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            using (var db = new ETSEntities())
            {
                db.Birimler.Add(new Birimler
                {
                    Birim = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }
            SetBirimler();
            e.Handled = true;
        }

        /// <summary>
        /// Arşivle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;
            using (var db = new ETSEntities())
            {
                var arsivle = new ArsivGelenGiden
                {
                    IlkEvrak = int.Parse(txtIlkEvrak.Text),
                    IlgiliEvrak = int.Parse(txtIlgiliEvrak.Text),
                    DosyaNo = int.Parse(txtDosyaNo.Text),
                    CikaranMakamId = int.Parse(txtEvrakiCikaranMakam.EditValue.ToString()),
                    Tarih = txtTarih.DateTime,
                    SubeId = int.Parse(txtSube.EditValue.ToString()),
                    EsasKonuNo = int.Parse(txtEsasKonuNo.Text),
                    AraSayiNo = int.Parse(txtAraSayiNo.Text),
                    Yil = int.Parse(txtYil.Text),
                    IlgiliBirimId = int.Parse(txtIlgiliBirim.EditValue.ToString()),
                    Konusu = txtKonusu.Text,
                    GizililikDerecesiId = int.Parse(txtGizlilikDerecesi.EditValue.ToString()),
                    EkSayisi = int.Parse(txtEkSayisi.Text),
                    ImhaYili = int.Parse(txtImhaYili.Text),
                };

                switch (_evrakTip)
                {
                    case EvrakTip.GelenEvrak:
                        arsivle.GelenEvrakId = _id;
                        break;
                    case EvrakTip.GidenEvrak:
                        arsivle.GidenEvrakId = _id;
                        break;
                }

                db.ArsivGelenGiden.Add(arsivle);
                db.SaveChanges();

                switch (_evrakTip)
                {
                    case EvrakTip.GelenEvrak:
                        var gelenEvrak = db.GelenEvrak.SingleOrDefault(s => s.Id == _id);
                        if (gelenEvrak != null) gelenEvrak.Arsivlendi = true;
                        db.Entry(gelenEvrak).State = EntityState.Modified;
                        db.SaveChanges();
                        break;
                    case EvrakTip.GidenEvrak:
                        arsivle.GidenEvrakId = _id;
                        var gidenEvrak = db.GidenEvrak.SingleOrDefault(s => s.Id == _id);
                        if (gidenEvrak != null) gidenEvrak.Arsivlendi = true;
                        db.Entry(gidenEvrak).State = EntityState.Modified;
                        db.SaveChanges();
                        break;
                }
            }

            XtraMessageBox.Show("Arşiv başarıyla oluşturuldu");

            Close();
        }
    }
}