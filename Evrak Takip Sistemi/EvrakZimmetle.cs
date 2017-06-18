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
    public partial class EvrakZimmetle : Form
    {
        private readonly bool _duzenlemeModu;
        private readonly EvrakTip _evrakTip;
        private readonly long _id;

        /// <summary>
        ///     Evrak zimmetleme ve düzenleme ekranı
        /// </summary>
        /// <param name="id">Zimmetlenecek Evrak ID</param>
        /// <param name="evrakTipi">Zimmetlenecek Evrak Tipi</param>
        /// <param name="duzenlemeModu">Düzenlenen zimmet mi</param>
        public EvrakZimmetle(long id, EvrakTip evrakTipi, bool duzenlemeModu)
        {
            InitializeComponent();
            _duzenlemeModu = duzenlemeModu;
            _id = id;
            _evrakTip = evrakTipi;
        }

        /// <summary>
        ///     Zimmetle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvrakiZimmetle_Click(object sender, EventArgs e)
        {
            if (txtEvrakKategorisi.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEvrakKategorisi.Focus();
                return;
            }

            switch (_evrakTip)
            {
                case EvrakTip.GelenEvrak:
                    txtEvrakTipi.Text = "Gelen Evrak";
                    using (var db = new ETSEntities())
                    {
                        var gelenEvrak = db.GelenEvrak.SingleOrDefault(x => x.Id == _id);
                        var gelenEvrakZimmeti = db.ZimmetDefteri.SingleOrDefault(x => x.GelenEvrakId == gelenEvrak.Id);

                        if (gelenEvrak != null)
                        {
                            if (gelenEvrakZimmeti == null)
                            {
                                var zimmetDefteri = new ZimmetDefteri
                                {
                                    KategoriId = int.Parse(txtEvrakKategorisi.EditValue.ToString()),
                                    SiraNo = int.Parse(txtZimmetSiraNo.Text),
                                    ZimmetTarihi = gelenEvrak.TarihTSG,
                                    TeslimAlanId = int.Parse(txtEvrakiTeslimAlan.EditValue.ToString()),
                                    GelenEvrakId = gelenEvrak.Id,
                                    GidenEvrakId = null
                                };

                                db.ZimmetDefteri.Add(zimmetDefteri);
                                gelenEvrak.Durum = 1;
                                db.Entry(gelenEvrak).State = EntityState.Modified;
                            }
                            else
                            {
                                gelenEvrakZimmeti.SiraNo = int.Parse(txtZimmetSiraNo.Text);
                                gelenEvrakZimmeti.ZimmetTarihi = gelenEvrak.TarihTSG;
                                gelenEvrakZimmeti.KategoriId = int.Parse(txtEvrakKategorisi.EditValue.ToString());
                                gelenEvrakZimmeti.TeslimAlanId = int.Parse(txtEvrakiTeslimAlan.EditValue.ToString());
                                db.Entry(gelenEvrakZimmeti).State = EntityState.Modified;
                            }
                        }

                        db.SaveChanges();
                    }

                    XtraMessageBox.Show("Evrak başarıyla zimmetlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    break;
                case EvrakTip.GidenEvrak:
                    txtEvrakTipi.Text = "Giden Evrak";
                    using (var db = new ETSEntities())
                    {
                        var gidenEvrak = db.GidenEvrak.SingleOrDefault(x => x.Id == _id);
                        var gidenEvrakZimmeti = db.ZimmetDefteri.SingleOrDefault(x => x.GidenEvrakId == gidenEvrak.Id);

                        if (gidenEvrak != null)
                        {
                            if (gidenEvrakZimmeti == null)
                            {
                                var zimmetDefteri = new ZimmetDefteri
                                {
                                    KategoriId = int.Parse(txtEvrakKategorisi.EditValue.ToString()),
                                    SiraNo = int.Parse(txtZimmetSiraNo.Text),
                                    ZimmetTarihi = gidenEvrak.TarihTSG,
                                    TeslimAlanId = int.Parse(txtEvrakiTeslimAlan.EditValue.ToString()),
                                    GidenEvrakId = gidenEvrak.Id,
                                    GelenEvrakId = null
                                };

                                db.ZimmetDefteri.Add(zimmetDefteri);
                                gidenEvrak.Durum = 1;
                                db.Entry(gidenEvrak).State = EntityState.Modified;
                            }
                            else
                            {
                                gidenEvrakZimmeti.SiraNo = int.Parse(txtZimmetSiraNo.Text);
                                gidenEvrakZimmeti.ZimmetTarihi = gidenEvrak.TarihTSG;
                                gidenEvrakZimmeti.KategoriId = int.Parse(txtEvrakKategorisi.EditValue.ToString());
                                gidenEvrakZimmeti.TeslimAlanId = int.Parse(txtEvrakiTeslimAlan.EditValue.ToString());
                                db.Entry(gidenEvrakZimmeti).State = EntityState.Modified;
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            XtraMessageBox.Show("Kayıt Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    XtraMessageBox.Show("Evrak başarıyla zimmetlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    break;
            }
        }

        /// <summary>
        ///     Form yüklenirken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EvrakZimmetle_Load(object sender, EventArgs e)
        {
            SetKategori();
            SetPersonel();

            using (var db = new ETSEntities())
            {
                txtEvrakKategorisi.Properties.DataSource = new ETSEntities().EvrakKategori.ToList();

                if (_duzenlemeModu)
                {
                    switch (_evrakTip)
                    {
                        case EvrakTip.GelenEvrak:
                            var gelenEvrak = db.GidenEvrak.SingleOrDefault(x => x.Id == _id);
                            var gelenEvrakZimmeti = db.ZimmetDefteri.SingleOrDefault(x => x.GidenEvrakId == gelenEvrak.Id);
                            if (gelenEvrakZimmeti != null)
                            {
                                txtZimmetSiraNo.Text = gelenEvrakZimmeti.SiraNo.ToString(CultureInfo.InvariantCulture);
                                txtEvrakKategorisi.EditValue = gelenEvrakZimmeti.KategoriId;
                                txtZimmetTarihi.DateTime = gelenEvrakZimmeti.ZimmetTarihi;
                                txtEvrakiTeslimAlan.EditValue = gelenEvrakZimmeti.TeslimAlanId;
                            }
                            break;
                        case EvrakTip.GidenEvrak:
                            var gidenEvrak = db.GidenEvrak.SingleOrDefault(x => x.Id == _id);
                            var gidenEvrakZimmeti = db.ZimmetDefteri.SingleOrDefault(x => x.GidenEvrakId == gidenEvrak.Id);
                            if (gidenEvrakZimmeti != null)
                            {
                                txtZimmetSiraNo.Text = gidenEvrakZimmeti.SiraNo.ToString(CultureInfo.InvariantCulture);
                                txtEvrakKategorisi.EditValue = gidenEvrakZimmeti.KategoriId;
                                txtZimmetTarihi.DateTime = gidenEvrakZimmeti.ZimmetTarihi;
                                txtEvrakiTeslimAlan.EditValue = gidenEvrakZimmeti.TeslimAlanId;
                            }
                            break;
                    }
                }
                else
                {
                    var zimmetDefteriSet = db.ZimmetDefteri.OrderByDescending(l => l.Id).FirstOrDefault();
                    txtZimmetSiraNo.Text = zimmetDefteriSet != null ? (zimmetDefteriSet.SiraNo + 1).ToString(CultureInfo.InvariantCulture) : "1";
                    txtZimmetTarihi.DateTime = DateTime.Now;
                }

                switch (_evrakTip)
                {
                    case EvrakTip.GelenEvrak:
                        txtEvrakTipi.Text = "Gelen Evrak";

                        var gelenEvrakOnizleme = db.GelenEvrak.SingleOrDefault(x => x.Id == _id);

                        if (gelenEvrakOnizleme != null)
                        {
                            txtPrvEvrakKayitNo.Text = gelenEvrakOnizleme.EvrakKayitNo.ToString(CultureInfo.InvariantCulture);
                            txtPrvAciklama.Text = gelenEvrakOnizleme.Aciklama;
                            txtPrvDosyaNoKonusu.Text = gelenEvrakOnizleme.DosyaNoKonusu;
                            txtPrvEvrakIslemSonTarihi.Text = gelenEvrakOnizleme.EvrakSonTarihi.ToString(CultureInfo.InvariantCulture);
                            txtPrvEvrakKayitTarihi.Text = gelenEvrakOnizleme.EvrakKayitTarihi.ToString(CultureInfo.InvariantCulture);
                            txtPrvEvrakTarihi.Text = gelenEvrakOnizleme.TarihTSG.ToString(CultureInfo.InvariantCulture);
                            txtPrvEvrakiCikaranMakam.Text = gelenEvrakOnizleme.EvrakiCikaranMakam.Makam;
                            txtPrvGizlilikDerecesi.Text = gelenEvrakOnizleme.GizlilikDerecesi.Derece;
                            txtPrvGonderdigiMakam.Text = gelenEvrakOnizleme.Personel.TamIsim;
                            txtPrvGuvenlikNoOncelikDerecesi.Text = gelenEvrakOnizleme.GuvenlikNoOncelikDerecesi.Derece;
                            chkPrvDurum.Checked = gelenEvrakOnizleme.Durum == 1;
                        }
                        else
                        {
                            throw new Exception("Zimmetlenecek Kayıt Bulunamadı");
                        }

                        break;
                    case EvrakTip.GidenEvrak:
                        txtEvrakTipi.Text = "Giden Evrak";

                        var gidenEvrakOnizleme = db.GidenEvrak.SingleOrDefault(x => x.Id == _id);

                        if (gidenEvrakOnizleme != null)
                        {
                            txtPrvEvrakKayitNo.Text = gidenEvrakOnizleme.EvrakKayitNo.ToString(CultureInfo.InvariantCulture);
                            txtPrvAciklama.Text = gidenEvrakOnizleme.Aciklama;
                            txtPrvDosyaNoKonusu.Text = gidenEvrakOnizleme.DosyaNoKonusu;
                            txtPrvEvrakIslemSonTarihi.Text = gidenEvrakOnizleme.EvrakSonTarihi.ToString(CultureInfo.InvariantCulture);
                            txtPrvEvrakKayitTarihi.Text = gidenEvrakOnizleme.EvrakKayitTarihi.ToString(CultureInfo.InvariantCulture);
                            txtPrvEvrakTarihi.Text = gidenEvrakOnizleme.TarihTSG.ToString(CultureInfo.InvariantCulture);
                            txtPrvEvrakiCikaranMakam.Text = gidenEvrakOnizleme.EvrakiCikaranMakam.Makam;
                            txtPrvGizlilikDerecesi.Text = gidenEvrakOnizleme.GizlilikDerecesi.Derece;
                            txtPrvGonderdigiMakam.Text = gidenEvrakOnizleme.GonderdigiMakam.Makam;
                            txtPrvGuvenlikNoOncelikDerecesi.Text = gidenEvrakOnizleme.GuvenlikNoOncelikDerecesi.Derece;
                            chkPrvDurum.Checked = gidenEvrakOnizleme.Durum == 1;
                        }
                        else
                        {
                            Close();
                            throw new Exception("Zimmetlenecek Kayıt Bulunamadı");
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Yeni Evrak Kategorisi girişi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEvrakKategorisi_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            using (var db = new ETSEntities())
            {
                db.EvrakKategori.Add(new EvrakKategori
                {
                    Kategori = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }

            SetKategori();
            e.Handled = true;
        }

        /// <summary>
        /// Yeni Evrak Teslim Alan bilgisi girişi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEvrakiTeslimAlan_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            using (var db = new ETSEntities())
            {
                db.Personel.Add(new Personel
                {
                    Adi = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }

            SetPersonel();
            e.Handled = true;
        }

        /// <summary>
        /// Kategori listesini doldurur
        /// </summary>
        private void SetKategori()
        {
            txtEvrakKategorisi.Properties.Columns.Clear();
            txtEvrakKategorisi.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Kategori",
                Caption = "Kategori"
            });
            txtEvrakKategorisi.Properties.DisplayMember = "Kategori";
            txtEvrakKategorisi.Properties.ValueMember = "Id";
            txtEvrakKategorisi.Properties.DataSource = new ETSEntities().EvrakKategori.ToList();
        }

        /// <summary>
        /// Personel listesini doldurur
        /// </summary>
        private void SetPersonel()
        {
            txtEvrakiTeslimAlan.Properties.Columns.Clear();
            txtEvrakiTeslimAlan.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Adi",
                Caption = "Adı"
            });
            txtEvrakiTeslimAlan.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Soyadi",
                Caption = "Soyadı"
            });
            txtEvrakiTeslimAlan.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Rutbesi",
                Caption = "Rutbesi"
            });
            txtEvrakiTeslimAlan.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "SicilNo",
                Caption = "Sicil No"
            });
            txtEvrakiTeslimAlan.Properties.DisplayMember = "Adi";
            txtEvrakiTeslimAlan.Properties.ValueMember = "Id";
            txtEvrakiTeslimAlan.Properties.DataSource = new ETSEntities().Personel.ToList();
        }
    }
}