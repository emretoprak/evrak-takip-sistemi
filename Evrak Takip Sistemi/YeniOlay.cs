using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Native;
using ETS.Akislar.DomainDataObjects;
using ETS.VeriKatmani;
using Newtonsoft.Json;

namespace ETS
{
    public partial class YeniOlay : Form
    {
        private static KayitDuzenleDTO _kayitDuzenle;

        public YeniOlay(KayitDuzenleDTO kayitDuzenle)
        {
            _kayitDuzenle = kayitDuzenle;
            InitializeComponent();

            SetKimlikBilgisi();
            SetSuclar();
            SetOlayYeri();
            SetPeriyot();
            SetPersonel();
            txtBaslik.Properties.DataSource = new ETSEntities().Baslik.ToList();

            if (_kayitDuzenle.Duzenleme)
            {
                DuzenlemeyiHazirla();
            }
        }

        private void DuzenlemeyiHazirla()
        {
            using (var db = new ETSEntities())
            {
                var duzenlenecekOlay = db.DaimiArastirmaTutanaklari.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekOlay != null)
                {
                    foreach (var kimlikler in JsonConvert.DeserializeObject<string[]>(duzenlenecekOlay.Kimlikler))
                    {
                        listKimlik.Items.Add(kimlikler);
                    }

                    txtSuc.EditValue = duzenlenecekOlay.SucId;
                    txtOlayYer.EditValue = duzenlenecekOlay.OlayYeriId;
                    txtOlayTarihi.DateTime = duzenlenecekOlay.OlayTarihi;
                    txtOlaySorusturmaNo.Text = duzenlenecekOlay.OlaySorusturmaNo;
                    txtDaimiAramaNo.Text = duzenlenecekOlay.DaimiAramaNo;
                    txtDaimiAramaKararTarihi.DateTime = duzenlenecekOlay.DaimiAramaKarariTarihi;
                    txtZamanAsimi.DateTime = duzenlenecekOlay.ZamanAsimi;
                    txtOzet.Text = duzenlenecekOlay.Ozet;
                    chkDurum.Checked = duzenlenecekOlay.Durum == 1;
                    txtBaslik.EditValue = duzenlenecekOlay.BaslikId;
                    txtPeriyotYili.DateTime = new DateTime(duzenlenecekOlay.PeriyotYili, 01, 01);
                    txtPeriyot.EditValue = duzenlenecekOlay.PeriyotId;
                    txtPersonel1.EditValue = duzenlenecekOlay.Personel1Id;
                    txtPersonel2.EditValue = duzenlenecekOlay.Personel2Id;
                    txtPersonel3.EditValue = duzenlenecekOlay.Personel3Id;
                    txtPersonel4.EditValue = duzenlenecekOlay.Personel4Id;

                    Text = "Düzenle";
                    btnDuzenlemeyiKaydet.Visible = true;
                    btnGonder.Visible = false;
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }
            }
        }

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

        private void SetOlayYeri()
        {
            txtOlayYer.Properties.Columns.Clear();
            txtOlayYer.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "OlayYeri",
                Caption = "Olay Yeri"
            });
            txtOlayYer.Properties.DisplayMember = "OlayYeri";
            txtOlayYer.Properties.ValueMember = "Id";
            txtOlayYer.Properties.DataSource = new ETSEntities().OlayYerleri.ToList();
        }

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

        private void SetPersonel()
        {
            txtPersonel1.Properties.Columns.Clear();
            txtPersonel1.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel1.Properties.DisplayMember = "TamIsim";
            txtPersonel1.Properties.ValueMember = "Id";
            txtPersonel1.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();

            txtPersonel2.Properties.Columns.Clear();
            txtPersonel2.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel2.Properties.DisplayMember = "TamIsim";
            txtPersonel2.Properties.ValueMember = "Id";
            txtPersonel2.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();

            txtPersonel3.Properties.Columns.Clear();
            txtPersonel3.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel3.Properties.DisplayMember = "TamIsim";
            txtPersonel3.Properties.ValueMember = "Id";
            txtPersonel3.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();

            txtPersonel4.Properties.Columns.Clear();
            txtPersonel4.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel4.Properties.DisplayMember = "TamIsim";
            txtPersonel4.Properties.ValueMember = "Id";
            txtPersonel4.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();

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

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate(txtSuc))
            {
                return;
            }
            if (!validationProvider.Validate(txtDaimiAramaKararTarihi))
            {
                return;
            }
            if (!validationProvider.Validate(txtDaimiAramaNo))
            {
                return;
            }
            if (!validationProvider.Validate(txtOlaySorusturmaNo))
            {
                return;
            }
            if (!validationProvider.Validate(txtOlayTarihi))
            {
                return;
            }
            if (!validationProvider.Validate(txtOlayYer))
            {
                return;
            }
            if (!validationProvider.Validate(txtOzet))
            {
                return;
            }
            if (!validationProvider.Validate(txtPeriyot))
            {
                return;
            }
            if (!validationProvider.Validate(txtPeriyotYili))
            {
                return;
            }
            if (!validationProvider.Validate(txtPersonel1))
            {
                return;
            }
            if (!validationProvider.Validate(txtPersonel2))
            {
                return;
            }
            if (!validationProvider.Validate(txtZamanAsimi))
            {
                return;
            }
            var daimiArastirmaTutanaklari = new DaimiArastirmaTutanaklari
            {
                SucId = int.Parse(txtSuc.EditValue.ToString()),
                DaimiAramaKarariTarihi = txtDaimiAramaKararTarihi.DateTime,
                DaimiAramaNo = txtDaimiAramaNo.Text,
                Durum = chkDurum.Checked ? 1 : 0,
                OlaySorusturmaNo = txtOlaySorusturmaNo.Text,
                OlayTarihi = txtOlayTarihi.DateTime,
                OlayYeriId = int.Parse(txtOlayYer.EditValue.ToString()),
                Ozet = txtOzet.Text,
                PeriyotId = int.Parse(txtPeriyot.EditValue.ToString()),
                PeriyotYili = int.Parse(txtPeriyotYili.Text),
                Personel1Id = int.Parse(txtPersonel1.EditValue.ToString()),
                Personel2Id = int.Parse(txtPersonel2.EditValue.ToString()),
                ZamanAsimi = txtZamanAsimi.DateTime
            };

            if (txtBaslik.EditValue.ToString().Length > 10)
            {
                XtraMessageBox.Show("Lütfen başlık seçiniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtBaslik.Focus();
                return;
            }

            daimiArastirmaTutanaklari.BaslikId = int.Parse(txtBaslik.EditValue.ToString());

            if (listKimlik.Items.Count < 1)
            {
                XtraMessageBox.Show("Lütfen en az bir kimlik ekleyiniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtKimlikBilgisi.Focus();
                return;
            }

            daimiArastirmaTutanaklari.Kimlikler = JsonConvert.SerializeObject(listKimlik.Items);

            using (var db = new ETSEntities())
            {
                db.DaimiArastirmaTutanaklari.Add(daimiArastirmaTutanaklari);
                db.SaveChanges();
            }

            XtraMessageBox.Show("Olay bilgisi girişi yapıldı", "Durum :", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private void btnKimlikEkle_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate(txtKimlikBilgisi))
            {
                return;
            }
            if (listKimlik.Items.Cast<object>().Any(t => int.Parse(t.ToString().Split('-')[0]) == int.Parse(txtKimlikBilgisi.EditValue.ToString())))
            {
                XtraMessageBox.Show("Bu kayıt daha önce eklenmiş");
                return;
            }

            listKimlik.Items.Add(int.Parse(txtKimlikBilgisi.EditValue.ToString()) + "-" + txtKimlikBilgisi.Text);
        }

        private void btnListedenSil_Click(object sender, EventArgs e)
        {
            listKimlik.Items.Remove(listKimlik.SelectedValue);
        }

        private void btnYeniKimlikEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKimlikAdi.Text))
            {
                XtraMessageBox.Show("Lütfen Yeni Kimlik için İsim giriniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtKimlikAdi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKimlikSoyadi.Text))
            {
                XtraMessageBox.Show("Lütfen Yeni Kimlik için Soyisim giriniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKimlikSoyadi.Focus();
                return;
            }

            var yeniKimlikBilgisi = new KimlikBilgileri
            {
                Adi = txtKimlikAdi.Text,
                Soyadi = txtKimlikSoyadi.Text,
                BabaAdi = txtKimlikBabaAdi.Text,
                Adresi = txtKimlikAdresi.Text,
                Telefon = txtKimlikTelefon.Text.Length > 1 ? long.Parse(txtKimlikTelefon.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty)) : new long(),
                TCKimlikNo = txtKimlikTCKimlik.Text.Length > 1 ? long.Parse(txtKimlikTCKimlik.Text) : new long(),
                DogumTarihi = txtKimlikDogumTarihi.Text.Length > 1 ? txtKimlikDogumTarihi.DateTime : new DateTime(2014, 09, 06),
                AdSoyad = txtKimlikAdi.Text + " " + txtKimlikSoyadi.Text
            };

            using (var db = new ETSEntities())
            {
                db.KimlikBilgileri.Add(yeniKimlikBilgisi);
                db.SaveChanges();
            }

            listKimlik.Items.Add(yeniKimlikBilgisi.Id + "-" + yeniKimlikBilgisi.AdSoyad);

            SetKimlikBilgisi();

            txtKimlikAdi.Text = null;
            txtKimlikSoyadi.Text = null;
            txtKimlikBabaAdi.Text = null;
            txtKimlikAdresi.Text = null;
            txtKimlikTelefon.Text = null;
            txtKimlikTCKimlik.Text = null;
            txtKimlikDogumTarihi.Text = null;
        }

        private void btnBaslikEkle_Click(object sender, EventArgs e)
        {
            if (txtBaslikPersonel.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen Yeni Başlık için bir personel seçiniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBaslikPersonel.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBaslikAnaBaslik.Text))
            {
                XtraMessageBox.Show("Lütfen Yeni Başlık için Ana Başlık giriniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBaslikAnaBaslik.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBaslikAnaBaslik.Text))
            {
                XtraMessageBox.Show("Lütfen Yeni Başlık için Ana Başlık giriniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBaslikAnaBaslik.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBaslikUstYaziBaslik.Text))
            {
                XtraMessageBox.Show("Lütfen Yeni Başlık için üst yazı başlığı giriniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBaslikUstYaziBaslik.Focus();
                return;
            }

            var yeniBaslik = new Baslik
            {
                AnaBaslik = txtBaslikAnaBaslik.Text,
                EkSayisi = int.Parse(txtBaslikEkSayisi.Text),
                PersonelId = int.Parse(txtBaslikPersonel.EditValue.ToString()),
                UstYaziBaslik = txtBaslikUstYaziBaslik.Text
            };

            using (var db = new ETSEntities())
            {
                db.Baslik.Add(yeniBaslik);
                db.SaveChanges();
            }

            txtBaslik.Properties.DataSource = new ETSEntities().Baslik.ToList();

            txtBaslikAnaBaslik.Text = null;
            txtBaslikEkSayisi.Text = null;
            txtBaslikPersonel.Text = null;
            txtBaslikUstYaziBaslik.Text = null;

            txtBaslik.Focus();
        }

        private void txtSuc_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
            {
                return;
            }

            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            using (var db = new ETSEntities())
            {
                db.Suclar.Add(new Suclar
                {
                    Suc = e.DisplayValue.ToString()
                });

                db.SaveChanges();
            }

            SetSuclar();
            e.Handled = true;
        }

        private void txtOlayYer_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            using (var db = new ETSEntities())
            {
                db.OlayYerleri.Add(new OlayYerleri
                {
                    OlayYeri = e.DisplayValue.ToString()
                });

                db.SaveChanges();
            }

            SetOlayYeri();
            e.Handled = true;
        }

        private void btnDuzenlemeyiKaydet_Click(object sender, EventArgs e)
        {
            if (listKimlik.Items.Count < 1)
            {
                XtraMessageBox.Show("Lütfen en az bir kimlik ekleyiniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKimlikBilgisi.Focus();
                return;
            }

            if (txtBaslik.EditValue.ToString().Length > 10)
            {
                XtraMessageBox.Show("Lütfen başlık seçiniz.", "Bir Hata Oluştu :", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtBaslik.Focus();
                return;
            }

            if (!validationProvider.Validate(txtSuc))
            {
                return;
            }
            if (!validationProvider.Validate(txtDaimiAramaKararTarihi))
            {
                return;
            }
            if (!validationProvider.Validate(txtDaimiAramaNo))
            {
                return;
            }
            if (!validationProvider.Validate(txtOlaySorusturmaNo))
            {
                return;
            }
            if (!validationProvider.Validate(txtOlayTarihi))
            {
                return;
            }
            if (!validationProvider.Validate(txtOlayYer))
            {
                return;
            }
            if (!validationProvider.Validate(txtOzet))
            {
                return;
            }
            if (!validationProvider.Validate(txtPeriyot))
            {
                return;
            }
            if (!validationProvider.Validate(txtPeriyotYili))
            {
                return;
            }
            if (!validationProvider.Validate(txtPersonel1))
            {
                return;
            }
            if (!validationProvider.Validate(txtPersonel2))
            {
                return;
            }
            if (!validationProvider.Validate(txtZamanAsimi))
            {
                return;
            }
            using (var db = new ETSEntities())
            {
                var duzenlenecekOlay = db.DaimiArastirmaTutanaklari.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekOlay != null)
                {
                    duzenlenecekOlay.SucId = int.Parse(txtSuc.EditValue.ToString());
                    duzenlenecekOlay.DaimiAramaKarariTarihi = txtDaimiAramaKararTarihi.DateTime;
                    duzenlenecekOlay.DaimiAramaNo = txtDaimiAramaNo.Text;
                    duzenlenecekOlay.Durum = chkDurum.Checked ? 1 : 0;
                    duzenlenecekOlay.OlaySorusturmaNo = txtOlaySorusturmaNo.Text;
                    duzenlenecekOlay.OlayTarihi = txtOlayTarihi.DateTime;
                    duzenlenecekOlay.OlayYeriId = int.Parse(txtOlayYer.EditValue.ToString());
                    duzenlenecekOlay.Ozet = txtOzet.Text;
                    duzenlenecekOlay.PeriyotId = int.Parse(txtPeriyot.EditValue.ToString());
                    duzenlenecekOlay.PeriyotYili = int.Parse(txtPeriyotYili.Text);
                    duzenlenecekOlay.Personel1Id = int.Parse(txtPersonel1.EditValue.ToString());
                    duzenlenecekOlay.Personel2Id = int.Parse(txtPersonel2.EditValue.ToString());
                    duzenlenecekOlay.ZamanAsimi = txtZamanAsimi.DateTime;
                    duzenlenecekOlay.BaslikId = int.Parse(txtBaslik.EditValue.ToString());
                    duzenlenecekOlay.Kimlikler = JsonConvert.SerializeObject(listKimlik.Items);
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }

                db.Entry(duzenlenecekOlay).State = EntityState.Modified;
                db.SaveChanges();
            }

            XtraMessageBox.Show("Olay bilgisi düzenlendi", "Durum :", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}