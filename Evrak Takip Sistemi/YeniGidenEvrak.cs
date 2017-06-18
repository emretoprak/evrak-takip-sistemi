using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Native;
using ETS.Akislar.DomainDataObjects;
using ETS.Akislar.Enums;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class YeniGidenEvrak : Form
    {
        private static KayitDuzenleDTO _kayitDuzenle;
        private static bool _zimmetliMi;

        public YeniGidenEvrak(KayitDuzenleDTO kayitDuzenle)
        {
            _kayitDuzenle = kayitDuzenle;
            InitializeComponent();
            SetEvrakiCikaranMakamlar();
            SetGizlilikDerecesi();
            SetGuvenlikNoOncelikDerecesi();
            SetGonderdigiMakam();
            SetOlayDurumu();
            SetOlayYeri();
            SetPersonel();

            if (!_kayitDuzenle.Duzenleme)
            {
                using (var db = new ETSEntities())
                {
                    var evrakKayitNo = db.GidenEvrak.OrderByDescending(l => l.EvrakKayitNo).FirstOrDefault();
                    txtEvrakKayitNo.Text = evrakKayitNo != null ? (evrakKayitNo.EvrakKayitNo + 1).ToString(CultureInfo.InvariantCulture) : "1";

                    var ayarlarl = db.Ayarlar.SingleOrDefault(x => x.Id == 1);
                    txtEvrakSonTarihi.DateTime = DateTime.Now.AddDays(ayarlarl != null ? ayarlarl.GidenEvrakEkGun : 10);
                }

                txtEvrakKayitTarihi.DateTime = DateTime.Now;
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
                var duzenlenecekGidenEvrak = db.GidenEvrak.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekGidenEvrak != null)
                {
                    txtEvrakKayitNo.Text = duzenlenecekGidenEvrak.EvrakKayitNo.ToString(CultureInfo.InvariantCulture);
                    txtEvrakKayitTarihi.DateTime = duzenlenecekGidenEvrak.EvrakKayitTarihi;
                    txtEvrakiCikaranMakam.EditValue = duzenlenecekGidenEvrak.EvrakiCikaranMakamId;
                    txtTarihTSG.DateTime = duzenlenecekGidenEvrak.TarihTSG;
                    txtDosyaNoKonusu.Text = duzenlenecekGidenEvrak.DosyaNoKonusu;
                    txtGizlilikDerecesi.EditValue = duzenlenecekGidenEvrak.GizlilikDerecesiId;
                    txtGuvenlikNoOncelikDerecesi.EditValue = duzenlenecekGidenEvrak.GuvenlikNoOncelikDerecesiId;
                    txtGonderildigiMakam.EditValue = duzenlenecekGidenEvrak.GonderdigiMakamId;
                    txtAciklama.Text = duzenlenecekGidenEvrak.Aciklama;
                    txtEvrakSonTarihi.DateTime = duzenlenecekGidenEvrak.EvrakSonTarihi;
                    chkDurum.Checked = duzenlenecekGidenEvrak.Durum != 0;
                    Text = "Düzenle";
                    btnYeniGidenGonder.Visible = false;
                    btnDuzenlemeKaydet.Visible = true;
                    btnDuzenlemeIptal.Visible = true;
                    txtOlayYeri.EditValue = duzenlenecekGidenEvrak.OlayYeriId;
                    txtPersonel2.EditValue = duzenlenecekGidenEvrak.PersonelId;

                    _zimmetliMi = duzenlenecekGidenEvrak.Durum != 0;
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }
            }
        }

        private void chkDurum_CheckedChanged(object sender, EventArgs e)
        {
            chkDurum.Text = chkDurum.Checked ? "Gönderildi" : "Bekliyor";
        }

        private void btnYeniGidenEvrakGonder_Click(object sender, EventArgs e)
        {
            if (txtGonderildigiMakam.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir gönderildiği makam seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGonderildigiMakam.Focus();
                return;
            }
            if (txtEvrakiCikaranMakam.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir evrakı çkartan makam seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEvrakiCikaranMakam.Focus();
                return;
            }
            if (txtGizlilikDerecesi.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir gizlilik derecesi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGizlilikDerecesi.Focus();
                return;
            }
            if (txtGuvenlikNoOncelikDerecesi.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen güvenlik no öncelik seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuvenlikNoOncelikDerecesi.Focus();
                return;
            }
            if (txtTarihTSG.DateTime < DateTime.Today.AddYears(-10))
            {
                XtraMessageBox.Show("Lütfen evrakın tarihini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarihTSG.Focus();
                return;
            }

            var yeniGidenEvrak = new GidenEvrak
            {
                Aciklama = txtAciklama.Text,
                GonderdigiMakamId = int.Parse(txtGonderildigiMakam.EditValue.ToString()),
                DosyaNoKonusu = txtDosyaNoKonusu.Text,
                Durum = 0,
                EvrakiCikaranMakamId = int.Parse(txtEvrakiCikaranMakam.EditValue.ToString()),
                GizlilikDerecesiId = int.Parse(txtGizlilikDerecesi.EditValue.ToString()),
                GuvenlikNoOncelikDerecesiId = int.Parse(txtGuvenlikNoOncelikDerecesi.EditValue.ToString()),
                TarihTSG = txtTarihTSG.DateTime,
                EvrakKayitNo = long.Parse(txtEvrakKayitNo.Text),
                EvrakKayitTarihi = txtEvrakKayitTarihi.DateTime,
                EvrakSonTarihi = txtEvrakSonTarihi.DateTime,
                OlayDurumuId = int.Parse(txtOlayDurumu.EditValue.ToString()),
                Arsivlendi = false
            };

            if (txtPersonel2.EditValue == null)
            {
                yeniGidenEvrak.PersonelId = null;
            }
            else
            {
                yeniGidenEvrak.PersonelId = int.Parse(txtPersonel2.EditValue.ToString());
            }

            if (txtOlayYeri.EditValue != null)
            {
                yeniGidenEvrak.OlayYeriId = int.Parse(txtOlayYeri.EditValue.ToString());
            }

            long yeniId;
            using (var db = new ETSEntities())
            {
                db.GidenEvrak.Add(yeniGidenEvrak);
                db.SaveChanges();
                yeniId = yeniGidenEvrak.Id;
            }

            if (chkDurum.Checked)
            {
                var evrakiZimmetle = new EvrakZimmetle(yeniId, EvrakTip.GidenEvrak, false);
                evrakiZimmetle.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Giden evrak başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }

        private void btnDuzenlemeKaydet_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;

            using (var db = new ETSEntities())
            {
                var duzenlenecekGidenEvrak = db.GidenEvrak.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekGidenEvrak != null)
                {
                    duzenlenecekGidenEvrak.EvrakKayitNo = long.Parse(txtEvrakKayitNo.Text);
                    duzenlenecekGidenEvrak.EvrakKayitTarihi = txtEvrakKayitTarihi.DateTime;
                    duzenlenecekGidenEvrak.EvrakiCikaranMakamId = int.Parse(txtEvrakiCikaranMakam.EditValue.ToString());
                    duzenlenecekGidenEvrak.TarihTSG = txtTarihTSG.DateTime;
                    duzenlenecekGidenEvrak.DosyaNoKonusu = txtDosyaNoKonusu.Text;
                    duzenlenecekGidenEvrak.GizlilikDerecesiId = int.Parse(txtGizlilikDerecesi.EditValue.ToString());
                    duzenlenecekGidenEvrak.GuvenlikNoOncelikDerecesiId = int.Parse(txtGuvenlikNoOncelikDerecesi.EditValue.ToString());
                    duzenlenecekGidenEvrak.GonderdigiMakamId = int.Parse(txtGonderildigiMakam.EditValue.ToString());
                    duzenlenecekGidenEvrak.Aciklama = txtAciklama.Text;
                    duzenlenecekGidenEvrak.EvrakSonTarihi = txtEvrakSonTarihi.DateTime;
                    duzenlenecekGidenEvrak.Durum = chkDurum.Checked ? 1 : 0;
                    if (txtPersonel2.EditValue != null)
                    {
                        duzenlenecekGidenEvrak.PersonelId = int.Parse(txtPersonel2.EditValue.ToString());
                    }
                    else
                    {
                        duzenlenecekGidenEvrak.PersonelId = null;
                    }

                    if (txtOlayYeri.EditValue != null)
                    {
                        duzenlenecekGidenEvrak.OlayYeriId = int.Parse(txtOlayYeri.EditValue.ToString());
                    }
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }

                db.Entry(duzenlenecekGidenEvrak).State = EntityState.Modified;

                if (duzenlenecekGidenEvrak.Durum.Equals(0))
                {
                    var zimmetDefteri = duzenlenecekGidenEvrak.ZimmetDefteri.FirstOrDefault();
                    if (zimmetDefteri != null)
                    {
                        var zimmetId = zimmetDefteri.Id;
                        var zimmetKaydi = db.ZimmetDefteri.SingleOrDefault(x => x.Id == zimmetId);

                        if (zimmetKaydi != null)
                        {
                            db.ZimmetDefteri.Remove(zimmetKaydi);
                        }
                    }
                }

                db.SaveChanges();

                if (chkDurum.Checked)
                {
                    var evrakiZimmetle = new EvrakZimmetle(duzenlenecekGidenEvrak.Id, EvrakTip.GidenEvrak, _zimmetliMi);
                    evrakiZimmetle.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Giden evrak başarıyla düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }

        private void btnDuzenlemeIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEvrakiCikaranMakam_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return;

            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

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
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return; if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

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

        private void txtGuvenlikNoOncelikDerecesi_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return; if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            using (var db = new ETSEntities())
            {
                db.GuvenlikNoOncelikDerecesi.Add(new GuvenlikNoOncelikDerecesi
                {
                    Derece = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }

            SetGuvenlikNoOncelikDerecesi();
            e.Handled = true;
        }

        private void txtGonderildigiMakam_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return; if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            using (var db = new ETSEntities())
            {
                db.GonderdigiMakam.Add(new GonderdigiMakam
                {
                    Makam = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }

            SetGonderdigiMakam();
            e.Handled = true;
        }

        private void txtOlayDurumu_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return; if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            using (var db = new ETSEntities())
            {
                db.OlayDurumu.Add(new OlayDurumu
                {
                    Durum = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }

            SetOlayDurumu();
            e.Handled = true;
        }

        private void txtOlayYeri_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
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
                db.OlayYerleri.Add(new OlayYerleri
                {
                    OlayYeri = e.DisplayValue.ToString()
                });

                db.SaveChanges();
            }

            SetOlayYeri();
            e.Handled = true;
        }

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

        private void SetGonderdigiMakam()
        {
            txtGonderildigiMakam.Properties.Columns.Clear();
            txtGonderildigiMakam.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Makam",
                Caption = "Makam"
            });
            txtGonderildigiMakam.Properties.DisplayMember = "Makam";
            txtGonderildigiMakam.Properties.ValueMember = "Id";
            txtGonderildigiMakam.Properties.DataSource = new ETSEntities().GonderdigiMakam.ToList();
        }

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

        private void SetPersonel()
        {
            txtPersonel2.Properties.Columns.Clear();
            txtPersonel2.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel2.Properties.DisplayMember = "TamIsim";
            txtPersonel2.Properties.ValueMember = "Id";
            txtPersonel2.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();
        }
    }
}
