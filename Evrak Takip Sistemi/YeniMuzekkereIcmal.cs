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
    public partial class YeniMuzekkereIcmal : Form
    {
        private static KayitDuzenleDTO _kayitDuzenle;

        public YeniMuzekkereIcmal(KayitDuzenleDTO kayitDuzenle)
        {
            _kayitDuzenle = kayitDuzenle;
            InitializeComponent();
            SetMahalle();
            SetMuzekkereCinsleri();
            SetKomutanlik();

            if (!_kayitDuzenle.Duzenleme)
            {
                using (var db = new ETSEntities())
                {
                    var fod = db.MuzekkereIcmalDefteri.OrderByDescending(l => l.Id).FirstOrDefault();
                    txtSiraNo.Text = fod != null ? (fod.Id + 1).ToString(CultureInfo.InvariantCulture) : "1";

                    txtGeldigiTarih.DateTime = DateTime.Now;
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
                var duzenlenecekIcmal = db.MuzekkereIcmalDefteri.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekIcmal != null)
                {
                    txtAciklama.Text = duzenlenecekIcmal.Aciklama;
                    txtAdiSoyadi.Text = duzenlenecekIcmal.AdiSoyadi;
                    txtDosyaNo.Text = duzenlenecekIcmal.DosyaNo;
                    txtGeldigiTarih.DateTime = duzenlenecekIcmal.GeldigiTarih;
                    if (duzenlenecekIcmal.GonderildigiTarih != null)
                    {
                        txtGonderildigiTarih.DateTime = (DateTime)duzenlenecekIcmal.GonderildigiTarih;
                    }
                    txtKomutanlik.EditValue = duzenlenecekIcmal.KomutanlikId;
                    txtMahalle.EditValue = duzenlenecekIcmal.MahalleId;
                    txtMuzekkereCinsi.EditValue = duzenlenecekIcmal.MuzekkereCinsiId;
                    txtDurum.SelectedIndex = duzenlenecekIcmal.Durum - 1;
                    txtSiraNo.Text = duzenlenecekIcmal.SiraNo.ToString(CultureInfo.InvariantCulture);

                    switch (duzenlenecekIcmal.Durum)
                    {
                        case 1:
                            txtDurum.SelectedIndex = 0;
                            break;
                        case 0:
                            txtDurum.SelectedIndex = 1;
                            break;
                        default:
                            txtDurum.SelectedIndex = 2;
                            break;
                    }
                    
                    
                    btnGonder.Visible = false;
                    btnDuzenlemeKaydet.Visible = true;
                    btnDuzenlemeIptal.Visible = false;
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }
            }
        }

        private void SetMahalle()
        {
            txtMahalle.Properties.Columns.Clear();
            txtMahalle.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "OlayYeri",
                Caption = "Mahalle / Köy"
            });
            txtMahalle.Properties.DisplayMember = "OlayYeri";
            txtMahalle.Properties.ValueMember = "Id";
            txtMahalle.Properties.DataSource = new ETSEntities().OlayYerleri.ToList();
        }

        private void SetMuzekkereCinsleri()
        {
            txtMuzekkereCinsi.Properties.Columns.Clear();
            txtMuzekkereCinsi.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Muzekkere",
                Caption = "Müzekkere Cinsi"
            });
            txtMuzekkereCinsi.Properties.DisplayMember = "Muzekkere";
            txtMuzekkereCinsi.Properties.ValueMember = "Id";
            txtMuzekkereCinsi.Properties.DataSource = new ETSEntities().MuzekkereCinsleri.ToList();
        }

        private void SetKomutanlik()
        {
            txtKomutanlik.Properties.Columns.Clear();
            txtKomutanlik.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Komutanlik",
                Caption = "Komutanlık"
            });
            txtKomutanlik.Properties.DisplayMember = "Komutanlik";
            txtKomutanlik.Properties.ValueMember = "Id";
            txtKomutanlik.Properties.DataSource = new ETSEntities().Komutanliklar.ToList();
        }

        private void txtMahalle_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
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

            SetMahalle();
            e.Handled = true;
        }

        private void txtMuzekkereCinsi_ProcessNewValue(object sender, ProcessNewValueEventArgs e){
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
                return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (var db = new ETSEntities())
            {
                db.MuzekkereCinsleri.Add(new MuzekkereCinsleri
                {
                    Muzekkere = e.DisplayValue.ToString()
                });

                db.SaveChanges();
            }

            SetMuzekkereCinsleri();
            e.Handled = true;
        }

        private void txtKomutanlik_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null)
                return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (var db = new ETSEntities())
            {
                db.Komutanliklar.Add(new Komutanliklar
                {
                    Komutanlik = e.DisplayValue.ToString()
                });

                db.SaveChanges();
            }

            SetKomutanlik();
            e.Handled = true;
        }
        
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;

            const int durum = 0;
            switch (txtDurum.SelectedIndex)
            {
                case 1:
                    txtDurum.SelectedIndex = 0;
                    break;
                case 0:
                    txtDurum.SelectedIndex = 1;
                    break;
                default:
                    txtDurum.SelectedIndex = 2;
                    break;
            }

            var yeniIcmal = new MuzekkereIcmalDefteri
            {
                Aciklama = txtAciklama.Text,
                AdiSoyadi = txtAdiSoyadi.Text,
                DosyaNo = txtDosyaNo.Text,
                Durum =  durum,
                GeldigiTarih = txtGeldigiTarih.DateTime,
                MahalleId = int.Parse(txtMahalle.EditValue.ToString()),
                MuzekkereCinsiId = int.Parse(txtMuzekkereCinsi.EditValue.ToString()),
                KomutanlikId = int.Parse(txtKomutanlik.EditValue.ToString()),
                SiraNo = long.Parse(txtSiraNo.Text)
            };
            
            if (!string.IsNullOrWhiteSpace(txtGonderildigiTarih.Text))
            {
                yeniIcmal.GonderildigiTarih = txtGonderildigiTarih.DateTime;
            }

            using (var db = new ETSEntities())
            {
                db.MuzekkereIcmalDefteri.Add(yeniIcmal);
                db.SaveChanges();
            }

            XtraMessageBox.Show("İcmal başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void btnDuzenlemeKaydet_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;

            const int durum = 0;
            switch (txtDurum.SelectedIndex)
            {
                case 1:
                    txtDurum.SelectedIndex = 0;
                    break;
                case 0:
                    txtDurum.SelectedIndex = 1;
                    break;
                default:
                    txtDurum.SelectedIndex = 2;
                    break;
            }
            
            using (var db = new ETSEntities())
            {
                var duzenlenecekIcmal = db.MuzekkereIcmalDefteri.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekIcmal != null)
                {
                    duzenlenecekIcmal.Aciklama = txtAciklama.Text;
                    duzenlenecekIcmal.AdiSoyadi = txtAdiSoyadi.Text;
                    duzenlenecekIcmal.DosyaNo = txtDosyaNo.Text;
                    duzenlenecekIcmal.Durum = durum;
                    duzenlenecekIcmal.GeldigiTarih = txtGeldigiTarih.DateTime;
                    duzenlenecekIcmal.MahalleId = int.Parse(txtMahalle.EditValue.ToString());
                    duzenlenecekIcmal.MuzekkereCinsiId = int.Parse(txtMuzekkereCinsi.EditValue.ToString());
                    duzenlenecekIcmal.KomutanlikId = int.Parse(txtKomutanlik.EditValue.ToString());
                    duzenlenecekIcmal.SiraNo = long.Parse(txtSiraNo.Text);

                    if (!string.IsNullOrWhiteSpace(txtGonderildigiTarih.Text))
                    {
                        duzenlenecekIcmal.GonderildigiTarih = txtGonderildigiTarih.DateTime;
                    }
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }

                db.Entry(duzenlenecekIcmal).State = EntityState.Modified;

                db.SaveChanges();

                XtraMessageBox.Show("İcmal başarıyla düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void btnDuzenlemeIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}