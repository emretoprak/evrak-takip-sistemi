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
    public partial class YeniGelenEvrak : Form
    {
        private static KayitDuzenleDTO _kayitDuzenle;
        private static bool _zimmetliMi;

        public YeniGelenEvrak(KayitDuzenleDTO kayitDuzenle)
        {
            _kayitDuzenle = kayitDuzenle;
            InitializeComponent();
            SetEvrakiCikaranMakamlar();
            SetGizlilikDerecesi();
            SetGuvenlikNoOncelikDerecesi();
            SetGonderdigiMakam();
            SetOlayDurumu();
            SetOlayYeri();


            if (!_kayitDuzenle.Duzenleme)
            {
                using (var db = new ETSEntities())
                {
                    var evrakKayitNo = db.GelenEvrak.OrderByDescending(l => l.EvrakKayitNo).FirstOrDefault();
                    txtEvrakKayitNo.Text = evrakKayitNo != null ? (evrakKayitNo.EvrakKayitNo + 1).ToString(CultureInfo.InvariantCulture) : "1";

                    var ayarlar = db.Ayarlar.SingleOrDefault(x => x.Id == 1);
                    txtEvrakSonTarihi.DateTime = DateTime.Now.AddDays(ayarlar != null ? ayarlar.GelenEvrakEkGun : 10);
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
                var duzenlenecekGelenEvrak = db.GelenEvrak.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekGelenEvrak != null)
                {
                    txtEvrakKayitNo.Text = duzenlenecekGelenEvrak.EvrakKayitNo.ToString(CultureInfo.InvariantCulture);
                    txtEvrakKayitTarihi.DateTime = duzenlenecekGelenEvrak.EvrakKayitTarihi;
                    txtEvrakiCikaranMakam.EditValue = duzenlenecekGelenEvrak.EvrakiCikaranMakamId;
                    txtTarihTSG.DateTime = duzenlenecekGelenEvrak.TarihTSG;
                    txtDosyaNoKonusu.Text = duzenlenecekGelenEvrak.DosyaNoKonusu;
                    txtGizlilikDerecesi.EditValue = duzenlenecekGelenEvrak.GizlilikDerecesiId;
                    txtGuvenlikNoOncelikDerecesi.EditValue = duzenlenecekGelenEvrak.GuvenlikNoOncelikDerecesiId;
                    txtPersonel.EditValue = duzenlenecekGelenEvrak.PersonelId;
                    txtAciklama.Text = duzenlenecekGelenEvrak.Aciklama;
                    txtEvrakSonTarihi.DateTime = duzenlenecekGelenEvrak.EvrakSonTarihi;
                    chkDurum.Checked = duzenlenecekGelenEvrak.Durum != 0;
                    Text = "Düzenle";
                    btnYeniGelenEvrakGonder.Visible = false;
                    btnDuzenlemeKaydet.Visible = true;
                    btnDuzenlemeIptal.Visible = true;
                    txtOlayYeri.EditValue = duzenlenecekGelenEvrak.OlayYeriId;
                    txtOlayDurumu.EditValue = duzenlenecekGelenEvrak.OlayDurumuId;
                    _zimmetliMi = duzenlenecekGelenEvrak.Durum != 0;
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

        private void btnYeniGelenEvrakGonder_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;
            
            var yeniGelenEvrak = new GelenEvrak
            {
                Aciklama = txtAciklama.Text,
                PersonelId = int.Parse(txtPersonel.EditValue.ToString()),
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

            if (txtOlayYeri.EditValue != null)
            {
                yeniGelenEvrak.OlayYeriId = int.Parse(txtOlayYeri.EditValue.ToString());
            }

            long yeniId;
            using (var db = new ETSEntities())
            {
                db.GelenEvrak.Add(yeniGelenEvrak);
                db.SaveChanges();
                yeniId = yeniGelenEvrak.Id;
            }

            if (chkDurum.Checked)
            {
                var evrakiZimmetle = new EvrakZimmetle(yeniId, EvrakTip.GelenEvrak, _zimmetliMi);
                evrakiZimmetle.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Gelen evrak başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }

        private void btnEvrakKaydet_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;

            using (var db = new ETSEntities())
            {
                var duzenlenecekGelenEvrak = db.GelenEvrak.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekGelenEvrak != null)
                {
                    duzenlenecekGelenEvrak.EvrakKayitNo = long.Parse(txtEvrakKayitNo.Text);
                    duzenlenecekGelenEvrak.EvrakKayitTarihi = txtEvrakKayitTarihi.DateTime;
                    duzenlenecekGelenEvrak.EvrakiCikaranMakamId = int.Parse(txtEvrakiCikaranMakam.EditValue.ToString());
                    duzenlenecekGelenEvrak.TarihTSG = txtTarihTSG.DateTime;
                    duzenlenecekGelenEvrak.DosyaNoKonusu = txtDosyaNoKonusu.Text;
                    duzenlenecekGelenEvrak.GizlilikDerecesiId = int.Parse(txtGizlilikDerecesi.EditValue.ToString());
                    duzenlenecekGelenEvrak.GuvenlikNoOncelikDerecesiId = int.Parse(txtGuvenlikNoOncelikDerecesi.EditValue.ToString());
                    duzenlenecekGelenEvrak.PersonelId = int.Parse(txtPersonel.EditValue.ToString());
                    duzenlenecekGelenEvrak.Aciklama = txtAciklama.Text;
                    duzenlenecekGelenEvrak.EvrakSonTarihi = txtEvrakSonTarihi.DateTime;
                    duzenlenecekGelenEvrak.Durum = chkDurum.Checked ? 1 : 0;
                    duzenlenecekGelenEvrak.OlayDurumuId = int.Parse(txtOlayDurumu.EditValue.ToString());

                    if (txtOlayYeri.EditValue != null)
                    {
                        duzenlenecekGelenEvrak.OlayYeriId = int.Parse(txtOlayYeri.EditValue.ToString());
                    }
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }

                db.Entry(duzenlenecekGelenEvrak).State = EntityState.Modified;

                if (duzenlenecekGelenEvrak.Durum.Equals(0))
                {
                    var zimmetDefteri = duzenlenecekGelenEvrak.ZimmetDefteri.FirstOrDefault();
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
                    var evrakiZimmetle = new EvrakZimmetle(duzenlenecekGelenEvrak.Id, EvrakTip.GelenEvrak, false);
                    evrakiZimmetle.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Gelen evrak başarıyla düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtOlayDurumu_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
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
                db.OlayDurumu.Add(new OlayDurumu
                {
                    Durum = e.DisplayValue.ToString()
                });
                db.SaveChanges();
            }

            SetOlayDurumu();
            e.Handled = true;
        }

        private void txtEvrakiCikaranMakam_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.DisplayValue.ToString())) return; if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
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

            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
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

            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
            txtPersonel.Properties.Columns.Clear();
            txtPersonel.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel.Properties.DisplayMember = "TamIsim";
            txtPersonel.Properties.ValueMember = "Id";
            txtPersonel.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();
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
    }
}
