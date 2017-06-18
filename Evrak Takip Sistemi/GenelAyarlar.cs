using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class GenelAyarlar : Form
    {
        public GenelAyarlar()
        {
            InitializeComponent();
            SetEvrakiCikaranMakamlar();
            SetGizlilikDerecesi();
            SetGuvenlikNoOncelikDerecesi();
            SetOlayDurumu();
            SetOlayYeri();
            SetSuclar();
            SetPeriyot();
            SetBaslik();
            SetPersonel();
            SetKimlikBilgisi();
            SetKomutanliklar();
            SetMuzekkereCinsleri();
            SetBirimler();
            SetSubeler();
        }

        /// <summary>
        /// Ayarları veritabanına kaydet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyarlariKaydet_Click(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                var ayarlar = db.Ayarlar.SingleOrDefault(x => x.Id == 1);

                if (ayarlar != null)
                {
                    ayarlar.GelenEvrakEkGun = int.Parse(txtGelenEkGun.Text);
                    ayarlar.GidenEvrakEkGun = int.Parse(txtGidenEkGun.Text);
                    ayarlar.DaimiAramaTKontrol = chkDaimiAramaTKontrol.Checked;
                    ayarlar.GelenEvrakKontrol = chkGelenKontrol.Checked;
                    ayarlar.GidenEvrakKontrol = chkGidenKontrol.Checked;
                    ayarlar.DaimiAramaEkGun = int.Parse(txtDaimiAramaTuanaklariEkGun.Text);
                    ayarlar.DaimiAramaKontrolSuresi = int.Parse(txtDaimiSonSure.Text);
                    ayarlar.GelenEvrakKontrolSuresi = int.Parse(txtGelenSonSure.Text);
                    ayarlar.GidenEvrakKontrolSuresi = int.Parse(txtGidenSonSure.Text);

                    db.Entry(ayarlar).State = EntityState.Modified;
                }
                else
                {
                    db.Ayarlar.Add(new Ayarlar
                    {
                        GelenEvrakEkGun = int.Parse(txtGelenEkGun.Text),
                        GidenEvrakEkGun = int.Parse(txtGidenEkGun.Text),
                        GidenEvrakKontrol = chkGidenKontrol.Checked,
                        GelenEvrakKontrol = chkGelenKontrol.Checked,
                        DaimiAramaTKontrol = chkDaimiAramaTKontrol.Checked,
                        DaimiAramaEkGun = int.Parse(txtDaimiAramaTuanaklariEkGun.Text),
                        DaimiAramaKontrolSuresi = int.Parse(txtDaimiSonSure.Text),
                        GelenEvrakKontrolSuresi = int.Parse(txtGidenSonSure.Text),
                        GidenEvrakKontrolSuresi = int.Parse(txtGelenSonSure.Text)
                    });
                }
                db.SaveChanges();

                XtraMessageBox.Show("Ayarlar Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Formdan çıkış
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Form yüklenirken geçerli ayarlar alınır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenelAyarlar_Load(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                var ayarlar = db.Ayarlar.SingleOrDefault();
                if (ayarlar == null) return;
                var gidenEvrakKontrol = ayarlar.GidenEvrakKontrol;
                var gelenEvrakKontrol = ayarlar.GelenEvrakKontrol;
                var daimiAramaTKontrol = ayarlar.DaimiAramaTKontrol;

                if (gidenEvrakKontrol != null)
                {
                    chkGidenKontrol.Checked = (bool) gidenEvrakKontrol;
                }
                if (gelenEvrakKontrol != null)
                {
                    chkGelenKontrol.Checked = (bool) gelenEvrakKontrol;
                }
                if (daimiAramaTKontrol != null)
                {
                    chkDaimiAramaTKontrol.Checked = (bool) daimiAramaTKontrol;
                }

                txtGelenEkGun.Text = ayarlar.GelenEvrakEkGun.ToString(CultureInfo.InvariantCulture);
                txtGelenSonSure.Text = ayarlar.GelenEvrakKontrolSuresi.ToString();

                txtGidenEkGun.Text = ayarlar.GidenEvrakEkGun.ToString(CultureInfo.InvariantCulture);
                txtGidenSonSure.Text = ayarlar.GidenEvrakKontrolSuresi.ToString();

                txtDaimiAramaTuanaklariEkGun.Text = ayarlar.DaimiAramaEkGun.ToString(CultureInfo.InvariantCulture);
                txtDaimiSonSure.Text = ayarlar.DaimiAramaKontrolSuresi.ToString();
            }
        }

        /// <summary>
        /// Evrakı çıkaran makam listesi
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
        /// Gizlilik derecesi makam listesi
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
        /// Guvenlik No OncelikDerecesi listesi
        /// </summary>
        private void SetGuvenlikNoOncelikDerecesi()
        {
            txtGuvenlikNoOncelikDerecesi.Properties.Columns.Clear();
            txtGuvenlikNoOncelikDerecesi.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Derece",
                Caption = "Derece"
            });
            txtGuvenlikNoOncelikDerecesi.Properties.DisplayMember = "Derece";
            txtGuvenlikNoOncelikDerecesi.Properties.ValueMember = "Id";
            txtGuvenlikNoOncelikDerecesi.Properties.DataSource = new ETSEntities().GuvenlikNoOncelikDerecesi.ToList();
        }

        /// <summary>
        ///Olay durumu listesi
        /// </summary>
        private void SetOlayDurumu()
        {
            txtOlayDurumu.Properties.Columns.Clear();
            txtOlayDurumu.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Durum",
                Caption = "Durum"
            });
            txtOlayDurumu.Properties.DisplayMember = "Durum";
            txtOlayDurumu.Properties.ValueMember = "Id";
            txtOlayDurumu.Properties.DataSource = new ETSEntities().OlayDurumu.ToList();
        }

        /// <summary>
        /// Olay yeri listesi
        /// </summary>
        private void SetOlayYeri()
        {
            txtOlayYeri.Properties.Columns.Clear();
            txtOlayYeri.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "OlayYeri",
                Caption = "Olay Yeri"
            });
            txtOlayYeri.Properties.DisplayMember = "OlayYeri";
            txtOlayYeri.Properties.ValueMember = "Id";
            txtOlayYeri.Properties.DataSource = new ETSEntities().OlayYerleri.ToList();
        }

        /// <summary>
        /// Suçlar listesi
        /// </summary>
        private void SetSuclar()
        {
            txtSuc.Properties.Columns.Clear();
            txtSuc.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Suc",
                Caption = "Suç"
            });
            txtSuc.Properties.DisplayMember = "Suc";
            txtSuc.Properties.ValueMember = "Id";
            txtSuc.Properties.DataSource = new ETSEntities().Suclar.ToList();
        }

        /// <summary>
        /// Periyotlar listesi
        /// </summary>
        private void SetPeriyot()
        {
            txtPeriyot.Properties.Columns.Clear();
            txtPeriyot.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Periyot",
                Caption = "Periyot"
            });
            txtPeriyot.Properties.DisplayMember = "Periyot";
            txtPeriyot.Properties.ValueMember = "Id";
            txtPeriyot.Properties.DataSource = new ETSEntities().Periyotlar.ToList();
        }

        /// <summary>
        /// Komutanlıklar listesi
        /// </summary>
        private void SetKomutanliklar()
        {
            txtKomutanliklar.Properties.Columns.Clear();
            txtKomutanliklar.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Komutanlik",
                Caption = "Komutanlik"
            });
            txtKomutanliklar.Properties.DisplayMember = "Komutanlik";
            txtKomutanliklar.Properties.ValueMember = "Id";
            txtKomutanliklar.Properties.DataSource = new ETSEntities().Komutanliklar.ToList();
        }

        /// <summary>
        /// Müzekkere cinsleri listesi
        /// </summary>
        private void SetMuzekkereCinsleri()
        {
            txtMuzekkereCinsleri.Properties.Columns.Clear();
            txtMuzekkereCinsleri.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Muzekkere",
                Caption = "Muzekkere"
            });
            txtMuzekkereCinsleri.Properties.DisplayMember = "Muzekkere";
            txtMuzekkereCinsleri.Properties.ValueMember = "Id";
            txtMuzekkereCinsleri.Properties.DataSource = new ETSEntities().MuzekkereCinsleri.ToList();
        }

        /// <summary>
        /// Başlık listesi
        /// </summary>
        private void SetBaslik()
        {
            txtBaslik.Properties.DataSource = new ETSEntities().Baslik.ToList();
        }

        /// <summary>
        /// Personel listesi
        /// </summary>
        private void SetPersonel()
        {
            txtBaslikPersonel.Properties.Columns.Clear();
            txtBaslikPersonel.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtBaslikPersonel.Properties.DisplayMember = "TamIsim";
            txtBaslikPersonel.Properties.ValueMember = "Id";
            txtBaslikPersonel.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();
        }

        /// <summary>
        /// Kimlik listesi
        /// </summary>
        private void SetKimlikBilgisi()
        {
            var column = new[]
            {
                new LookUpColumnInfo
                {
                    FieldName = "TCKimlikNo",
                    Caption = "TC Kimlik No"
                },
                new LookUpColumnInfo
                {
                    FieldName = "Adi",
                    Caption = "Adı"
                },
                new LookUpColumnInfo
                {
                    FieldName = "Soyadi",
                    Caption = "Soyadı"
                },
                new LookUpColumnInfo
                {
                    FieldName = "BabaAdi",
                    Caption = "Baba Adı"
                },
                new LookUpColumnInfo
                {
                    FieldName = "DogumTarihi",
                    Caption = "Doğum Tarihi"
                },
                new LookUpColumnInfo
                {
                    FieldName = "Adresi",
                    Caption = "Adresi"
                },
                new LookUpColumnInfo
                {
                    FieldName = "Telefon",
                    Caption = "Telefon"
                }
            };

            txtKimlikBilgisi.Properties.Columns.Clear();
            txtKimlikBilgisi.Properties.Columns.AddRange(column);
            txtKimlikBilgisi.Properties.DisplayMember = "AdSoyad";
            txtKimlikBilgisi.Properties.ValueMember = "Id";
            txtKimlikBilgisi.Properties.DataSource = new ETSEntities().KimlikBilgileri.ToList();
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
        /// Listeden Evrakı çıkaran makam sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnECMSil_Click(object sender, EventArgs e)
        {
            if (txtEvrakiCikaranMakam.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtEvrakiCikaranMakam.EditValue.ToString());
                var evrakiCikaranMakam = db.EvrakiCikaranMakam.SingleOrDefault(s => s.Id == id);
                db.EvrakiCikaranMakam.Remove(evrakiCikaranMakam);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetEvrakiCikaranMakamlar();
                }
            }
        }

        /// <summary>
        /// Listeden Gizlilik derecesi makam sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGDSil_Click(object sender, EventArgs e)
        {
            if (txtGizlilikDerecesi.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtGizlilikDerecesi.EditValue.ToString());
                var gizlilikDerecesi = db.GizlilikDerecesi.SingleOrDefault(s => s.Id == id);
                db.GizlilikDerecesi.Remove(gizlilikDerecesi);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetGizlilikDerecesi();
                }
            }
        }

        /// <summary>
        /// Listeden Gücenlik no öncelik derecesi makam sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGNODSil_Click(object sender, EventArgs e)
        {
            if (txtGuvenlikNoOncelikDerecesi.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtGuvenlikNoOncelikDerecesi.EditValue.ToString());
                var guvenlikNoDerecesi = db.GuvenlikNoOncelikDerecesi.SingleOrDefault(s => s.Id == id);
                db.GuvenlikNoOncelikDerecesi.Remove(guvenlikNoDerecesi);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetGuvenlikNoOncelikDerecesi();
                }
            }
        }

        /// <summary>
        /// Listeden Olay durumu sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnODSİl_Click(object sender, EventArgs e)
        {
            if (txtOlayDurumu.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtOlayDurumu.EditValue.ToString());
                if (id == 4 || id == 5 || id == 6) return;
                var olayDurumuSil = db.OlayDurumu.SingleOrDefault(s => s.Id == id);
                db.OlayDurumu.Remove(olayDurumuSil);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetOlayDurumu();
                }
            }
        }

        /// <summary>
        /// Listeden Olay yeri sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOYSil_Click(object sender, EventArgs e)
        {
            if (txtOlayYeri.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtOlayYeri.EditValue.ToString());
                var olayYeri = db.OlayYerleri.SingleOrDefault(s => s.Id == id);
                db.OlayYerleri.Remove(olayYeri);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetOlayYeri();
                }
            }
        }

        /// <summary>
        /// Listeden Suç sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSucSil_Click(object sender, EventArgs e)
        {
            if (txtSuc.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtSuc.EditValue.ToString());
                var suc = db.Suclar.SingleOrDefault(s => s.Id == id);
                db.Suclar.Remove(suc);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetSuclar();
                }
            }
        }

        /// <summary>
        /// Listeden Periyot sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriyotSil_Click(object sender, EventArgs e)
        {
            if (txtPeriyot.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtPeriyot.EditValue.ToString());
                var periyot = db.Periyotlar.SingleOrDefault(s => s.Id == id);
                db.Periyotlar.Remove(periyot);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetPeriyot();
                }
            }
        }

        /// <summary>
        /// Listeden Başlık sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaslikSil_Click(object sender, EventArgs e)
        {
            if (txtBaslik.EditValue == null) return;

            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtBaslik.EditValue.ToString());
                var baslik = db.Baslik.SingleOrDefault(s => s.Id == id);
                db.Baslik.Remove(baslik);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    BaslikTemizle();
                    SetBaslik();
                }
            }
        }

        /// <summary>
        /// Başlık kaydet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaslikKaydet_Click(object sender, EventArgs e)
        {
            if (txtBaslik.EditValue == null) return;

            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtBaslik.EditValue.ToString());
                var baslik = db.Baslik.SingleOrDefault(s => s.Id == id);

                if (baslik == null) return;

                baslik.AnaBaslik = txtBaslikAnaBaslik.Text;
                baslik.UstYaziBaslik = txtBaslikUstYaziBaslik.Text;
                baslik.PersonelId = int.Parse(txtBaslikPersonel.EditValue.ToString());
                baslik.EkSayisi = int.Parse(txtBaslikEkSayisi.EditValue.ToString());

                db.Entry(baslik).State = EntityState.Modified;
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt düzenlendi");
                SetBaslik();
            }
        }

        /// <summary>
        /// Listeden Kimlik sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKimlikSil_Click(object sender, EventArgs e)
        {
            if (txtKimlikBilgisi.EditValue == null) return;

            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtKimlikBilgisi.EditValue.ToString());
                var kimlik = db.KimlikBilgileri.SingleOrDefault(s => s.Id == id);
                db.KimlikBilgileri.Remove(kimlik);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    KimlikTemizle();
                    SetKimlikBilgisi();
                }
            }
        }

        /// <summary>
        /// Kimlik kaydet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKimlikKaydet_Click(object sender, EventArgs e)
        {
            if (txtKimlikBilgisi.EditValue == null) return;

            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtKimlikBilgisi.EditValue.ToString());
                var kimlik = db.KimlikBilgileri.SingleOrDefault(s => s.Id == id);

                if (kimlik == null) return;

                kimlik.TCKimlikNo = int.Parse(txtKimlikTCKimlik.Text);
                kimlik.Adresi = txtKimlikAdresi.Text;
                kimlik.BabaAdi = txtKimlikBabaAdi.Text;
                kimlik.DogumTarihi = txtKimlikDogumTarihi.DateTime;
                kimlik.Soyadi = txtKimlikSoyadi.Text;
                kimlik.Telefon = long.Parse(txtKimlikTelefon.Text);

                db.Entry(kimlik).State = EntityState.Modified;
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt düzenlendi");
                SetKimlikBilgisi();
            }
        }

        /// <summary>
        /// Listeden komutanlık sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKomutanlikSil_Click(object sender, EventArgs e)
        {
            if (txtKomutanliklar.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtKomutanliklar.EditValue.ToString());
                if (id == 1 || id == 2) return;
                var komutanlik = db.Komutanliklar.SingleOrDefault(s => s.Id == id);
                db.Komutanliklar.Remove(komutanlik);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetKomutanliklar();
                }
            }
        }

        /// <summary>
        /// Listeden Müzekkere cinsi sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMuzekkereCinsiSil_Click(object sender, EventArgs e)
        {
            if (txtMuzekkereCinsleri.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtMuzekkereCinsleri.EditValue.ToString());
                if (id == 1 || id == 2 || id == 3 || id == 4) return;
                var mzkCins = db.MuzekkereCinsleri.SingleOrDefault(s => s.Id == id);
                db.MuzekkereCinsleri.Remove(mzkCins);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetMuzekkereCinsleri();
                }
            }
        }

        /// <summary>
        /// Listeden Şube sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            if (txtSube.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtSube.EditValue.ToString());
                var subeler = db.Subeler.SingleOrDefault(s => s.Id == id);
                db.Subeler.Remove(subeler);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetSubeler();
                }
            }
        }

        /// <summary>
        /// Listeden Birim sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBirimSil_Click(object sender, EventArgs e)
        {
            if (txtIlgiliBirim.EditValue == null) return;
            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtIlgiliBirim.EditValue.ToString());
                var birimler = db.Birimler.SingleOrDefault(s => s.Id == id);
                db.Birimler.Remove(birimler);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Bu kayda ilişkili başka bir kayıt bulunuyor lütfen önce ilişkili kayıtları değiştiriniz.");
                }
                finally
                {
                    SetBirimler();
                }
            }
        }

        /// <summary>
        /// Kimlik formunu temizle
        /// </summary>
        private void KimlikTemizle()
        {
            txtKimlikTCKimlik.Text = "";
            txtKimlikAdresi.Text = "";
            txtKimlikBabaAdi.Text = "";
            txtKimlikDogumTarihi.Text = "";
            txtKimlikSoyadi.Text = "";
            txtKimlikTCKimlik.Text = "";
            txtKimlikTelefon.Text = "";
        }

        /// <summary>
        /// Yeni Başlık ekle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBaslik_EditValueChanged(object sender, EventArgs e)
        {
            BaslikTemizle();

            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtBaslik.EditValue.ToString());
                var baslik = db.Baslik.SingleOrDefault(s => s.Id == id);

                if (baslik == null) return;
                txtBaslikAnaBaslik.Text = baslik.AnaBaslik;
                txtBaslikUstYaziBaslik.Text = baslik.UstYaziBaslik;
                txtBaslikPersonel.EditValue = baslik.PersonelId;
                txtBaslikEkSayisi.EditValue = baslik.EkSayisi;
            }
        }

        /// <summary>
        /// Başlık forumunu temizle
        /// </summary>
        private void BaslikTemizle()
        {
            txtBaslikAnaBaslik.Text = "";
            txtBaslikUstYaziBaslik.Text = "";
            txtBaslikPersonel.EditValue = null;
            txtBaslikEkSayisi.EditValue = null;
        }

        /// <summary>
        /// Yeni kimlik bilgisi ekle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKimlikBilgisi_EditValueChanged(object sender, EventArgs e)
        {
            KimlikTemizle();

            using (var db = new ETSEntities())
            {
                var id = int.Parse(txtKimlikBilgisi.EditValue.ToString());
                var kimlik = db.KimlikBilgileri.SingleOrDefault(s => s.Id == id);

                if (kimlik == null) return;
                txtKimlikTCKimlik.Text = kimlik.TCKimlikNo.ToString();
                txtKimlikAdresi.Text = kimlik.Adresi;
                txtKimlikBabaAdi.Text = kimlik.BabaAdi;
                txtKimlikDogumTarihi.Text = kimlik.DogumTarihi.ToString();
                txtKimlikSoyadi.Text = kimlik.Soyadi;
                txtKimlikTelefon.Text = kimlik.Telefon.ToString();
            }
        }
    }
}