using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Native;
using ETS.Akislar.DomainDataObjects;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class YeniGelenGidenArsiv : Form
    {
        private static KayitDuzenleDTO _kayitDuzenle;

        public YeniGelenGidenArsiv(KayitDuzenleDTO kayitDuzenle)
        {
            _kayitDuzenle = kayitDuzenle;
            InitializeComponent();
            SetEvrakiCikaranMakamlar();
            SetGizlilikDerecesi();
            SetSubeler();
            SetBirimler();

            if (!_kayitDuzenle.Duzenleme)
            {
                using (var db = new ETSEntities())
                {
                    var firstOrDefault = db.ArsivGelenGiden.OrderByDescending(l => l.Id).FirstOrDefault();
                    txtIlkEvrak.Text = firstOrDefault != null ? (firstOrDefault.Id + 1).ToString(CultureInfo.InvariantCulture) : "1";
                }
            }
            else
            {
                DuzenlemeyiHazirla();
            }
        }

        private void DuzenlemeyiHazirla()
        {
            using (var db = new ETSEntities())
            {
                var duzenlenecekEvrak = db.ArsivGelenGiden.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekEvrak != null)
                {
                    txtIlkEvrak.Text = duzenlenecekEvrak.IlkEvrak.ToString(CultureInfo.InvariantCulture);
                    txtIlgiliEvrak.Text = duzenlenecekEvrak.IlgiliEvrak.ToString();
                    txtDosyaNo.Text = duzenlenecekEvrak.DosyaNo.ToString();
                    txtEvrakiCikaranMakam.EditValue = duzenlenecekEvrak.CikaranMakamId;
                    txtTarih.DateTime = duzenlenecekEvrak.Tarih;
                    txtSube.EditValue = duzenlenecekEvrak.SubeId;
                    txtEsasKonuNo.Text = duzenlenecekEvrak.EsasKonuNo.ToString(CultureInfo.InvariantCulture);
                    txtAraSayiNo.Text = duzenlenecekEvrak.AraSayiNo.ToString(CultureInfo.InvariantCulture);
                    txtYil.Text = duzenlenecekEvrak.Yil.ToString(CultureInfo.InvariantCulture);
                    txtIlgiliBirim.EditValue = duzenlenecekEvrak.IlgiliBirimId;
                    txtKonusu.Text = duzenlenecekEvrak.Konusu;
                    txtGizlilikDerecesi.EditValue = duzenlenecekEvrak.GizililikDerecesiId;
                    txtEkSayisi.Text = duzenlenecekEvrak.EkSayisi.ToString(CultureInfo.InvariantCulture);
                    txtImhaYili.Text = duzenlenecekEvrak.ImhaYili.ToString();
                    Text = "Düzenle";
                    btnGonder.Visible = false;
                    btnKaydet.Visible = true;
                    btnIptal.Visible = true;
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }
            }
        }

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

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;

            using (var db = new ETSEntities())
            {
                db.ArsivGelenGiden.Add(new ArsivGelenGiden
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
                    ImhaYili = int.Parse(txtImhaYili.Text)
                });

                db.SaveChanges();
            }

            XtraMessageBox.Show("Arşiv başarıyla oluşturuldu");

            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;

            using (var db = new ETSEntities())
            {
                var duzenlenecekEvrak = db.ArsivGelenGiden.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekEvrak != null)
                {
                    duzenlenecekEvrak.IlkEvrak = int.Parse(txtIlkEvrak.Text);
                    duzenlenecekEvrak.IlgiliEvrak = int.Parse(txtIlgiliEvrak.Text);
                    duzenlenecekEvrak.DosyaNo = int.Parse(txtDosyaNo.Text);
                    duzenlenecekEvrak.CikaranMakamId = int.Parse(txtEvrakiCikaranMakam.EditValue.ToString());
                    duzenlenecekEvrak.Tarih = txtTarih.DateTime;
                    duzenlenecekEvrak.SubeId = int.Parse(txtSube.EditValue.ToString());
                    duzenlenecekEvrak.EsasKonuNo = int.Parse(txtEsasKonuNo.Text);
                    duzenlenecekEvrak.AraSayiNo = int.Parse(txtAraSayiNo.Text);
                    duzenlenecekEvrak.Yil = int.Parse(txtYil.Text);
                    duzenlenecekEvrak.IlgiliBirimId = int.Parse(txtIlgiliBirim.EditValue.ToString());
                    duzenlenecekEvrak.Konusu = txtKonusu.Text;
                    duzenlenecekEvrak.GizililikDerecesiId = int.Parse(txtGizlilikDerecesi.EditValue.ToString());
                    duzenlenecekEvrak.EkSayisi = int.Parse(txtEkSayisi.Text);
                    duzenlenecekEvrak.ImhaYili = int.Parse(txtImhaYili.Text);
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }

                db.Entry(duzenlenecekEvrak).State = EntityState.Modified;

                db.SaveChanges();

                XtraMessageBox.Show("Gelen Giden Arşiv evrağı başarıyla düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }
    }
}