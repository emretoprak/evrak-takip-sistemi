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
    public partial class YeniOlayBilgisi : Form
    {
        private int _tasnifId;
        private static KayitDuzenleDTO _kayitDuzenle;

        public YeniOlayBilgisi(KayitDuzenleDTO kayitDuzenleDTO)
        {
            _kayitDuzenle = kayitDuzenleDTO;
            InitializeComponent();
            SetSuclar();
            SetOlayYeri();
            SetKomutanlik();

            if (_kayitDuzenle.Duzenleme)
            {
                DuzenlemeyiHazirla();
            }
        }

        private void DuzenlemeyiHazirla()
        {
            using (var db = new ETSEntities())
            {
                var duzenlenecekOlay = db.OlaylarBilgisi.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);

                if (duzenlenecekOlay != null)
                {
                    txtSiraNo.Text = duzenlenecekOlay.SiraNo.ToString(CultureInfo.InvariantCulture);
                    txtOlayBilgisiNo.Text = duzenlenecekOlay.OlayBilNo.ToString(CultureInfo.InvariantCulture);
                    txtOlayTarihi.DateTime = duzenlenecekOlay.OlayTarihi;
                    txtOlayYeri.EditValue = duzenlenecekOlay.OlayYeriId;
                    txtOlay.EditValue = duzenlenecekOlay.OlayId;
                    txtKomutanlik.EditValue = duzenlenecekOlay.KomutanlikId;
                    txtTasnifBaslik.Text = duzenlenecekOlay.Tasnifler.Baslik;
                    txtTasnifAltBaslik.Text = duzenlenecekOlay.Tasnifler.AltBaslik;
                    txtTasnifGrup.Text = duzenlenecekOlay.Tasnifler.Grup;
                    txtTasnifSuc.Text = duzenlenecekOlay.Tasnifler.Suc;

                    Text = "Düzenle";
                    btnKaydet.Visible = true;
                    btnGonder.Visible = false;
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }
            }
        }

        /// <summary>
        /// Sayfa yüklenirken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Test_Load(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                // : Tasnif başlık bilgisi alınıyor
                var txtTasnifBaslikData = db.Tasnifler.Select(s => s.Baslik).Distinct().ToList();
                txtTasnifBaslik.Properties.DataSource = txtTasnifBaslikData;

                // : Son sıra numarası alınıyor
                var evrakKayitNo = db.GelenEvrak.OrderByDescending(l => l.EvrakKayitNo).FirstOrDefault();
                txtSiraNo.Text = evrakKayitNo != null ? (evrakKayitNo.EvrakKayitNo + 1).ToString(CultureInfo.InvariantCulture) : "1";
            }
        }

        /// <summary>
        /// Başlık bilgisi değiştiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtval1_EditValueChanged(object sender, EventArgs e)
        {
            var txtTasnif = sender as LookUpEdit;
            if (txtTasnif == null) return;
            using (var db = new ETSEntities())
            {
                var txtTasnifAltBaslikData = db.Tasnifler.Where(w => w.Baslik.Equals(txtTasnif.Text)).Select(s => s.AltBaslik).Distinct().ToList();
                txtTasnifAltBaslik.Properties.DataSource = txtTasnifAltBaslikData;
                txtTasnifAltBaslik.Enabled = true;
                txtTasnifSuc.Enabled = false;
                txtTasnifSuc.EditValue = null;
                txtTasnifGrup.Enabled = false;
                txtTasnifGrup.EditValue = null;
            }
        }

        /// <summary>
        /// Altbaşlık bilgisi değiştiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtval2_EditValueChanged(object sender, EventArgs e)
        {
            var txtTasnif = sender as LookUpEdit;
            if (txtTasnif == null) return;
            using (var db = new ETSEntities())
            {
                var txtTasnifSucData = db.Tasnifler.Where(w => w.Baslik.Equals(txtTasnifBaslik.Text) && w.AltBaslik.Equals(txtTasnif.Text)).Select(s => s.Suc).Distinct().ToList();
                txtTasnifSuc.Properties.DataSource = txtTasnifSucData;
                txtTasnifSuc.Enabled = true;
                txtTasnifGrup.Enabled = false;
                txtTasnifGrup.EditValue = null;
            }
        }

        /// <summary>
        /// Suç bilgisi değiştiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtval3_EditValueChanged(object sender, EventArgs e)
        {
            var txtTasnif = sender as LookUpEdit;
            if (txtTasnif == null) return;
            using (var db = new ETSEntities())
            {
                var txtTasnifGrupData = db.Tasnifler.Where(w => w.Baslik.Equals(txtTasnifBaslik.Text) && w.AltBaslik.Equals(txtTasnifAltBaslik.Text) && w.Suc.Equals(txtTasnif.Text)).Select(s => s.Grup).Distinct().ToList();
                txtTasnifGrup.Properties.DataSource = txtTasnifGrupData;
                txtTasnifGrup.Enabled = true;
            }
        }

        /// <summary>
        /// Grup bilgisi değiştiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtval4_EditValueChanged(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                var tasnif = db.Tasnifler.SingleOrDefault(w => w.Baslik.Equals(txtTasnifBaslik.Text) && w.AltBaslik.Equals(txtTasnifAltBaslik.Text) && w.Suc.Equals(txtTasnifSuc.Text) && w.Grup.Equals(txtTasnifGrup.Text));
                if (tasnif != null) _tasnifId = tasnif.Id;
            }
        }

        /// <summary>
        /// Yeni kaydı gönder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;

            if (_tasnifId <= 0)
            {
                XtraMessageBox.Show("Lütfen tasnif bilgisini seçiniz");
                return;
            }

            using (var db = new ETSEntities())
            {
                db.OlaylarBilgisi.Add(new OlaylarBilgisi
                {
                    KomutanlikId = int.Parse(txtKomutanlik.EditValue.ToString()),
                    OlayBilNo = long.Parse(txtOlayBilgisiNo.Text),
                    OlayId = int.Parse(txtOlay.EditValue.ToString()),
                    OlayTarihi = txtOlayTarihi.DateTime,
                    OlayYeriId = int.Parse(txtOlayYeri.EditValue.ToString()),
                    SiraNo = long.Parse(txtSiraNo.Text),
                    TansifId = _tasnifId
                });

                db.SaveChanges();
            }

            Close();
        }

        /// <summary>
        /// Suçlar listesini listeye doldurur
        /// </summary>
        private void SetSuclar()
        {
            txtOlay.Properties.Columns.Clear();
            txtOlay.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "Suc",
                Caption = "Suç"
            });
            txtOlay.Properties.DisplayMember = "Suc";
            txtOlay.Properties.ValueMember = "Id";
            txtOlay.Properties.DataSource = new ETSEntities().Suclar.ToList();
        }

        /// <summary>
        /// Olayyeri bilgisini listeye doldurur
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
        /// Komutanlık bilgisini listeye doldurur
        /// </summary>
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

        /// <summary>
        /// Yeni olay yeri ekleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOlayYeri_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
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

        /// <summary>
        /// Yeni olay ekleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOlay_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
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

        /// <summary>
        /// Yeni komutanlık ekleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKomutanlik_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue.ToString().IsEmpty() || e.DisplayValue == null) return;
            if (MessageBox.Show(this, e.DisplayValue + "' ekleniyor emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
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

        /// <summary>
        /// Düzenlenen bilgiyi kayıt eder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;

            if (_tasnifId <= 0)
            {
                XtraMessageBox.Show("Lütfen tasnif bilgisini seçiniz");
                return;
            }

            using (var db = new ETSEntities())
            {
                var duzenlenecekOlay = db.OlaylarBilgisi.SingleOrDefault(x => x.Id == _kayitDuzenle.EvrakId);
                if (duzenlenecekOlay != null)
                {
                    duzenlenecekOlay.KomutanlikId = int.Parse(txtKomutanlik.EditValue.ToString());
                    duzenlenecekOlay.OlayBilNo = long.Parse(txtOlayBilgisiNo.Text);
                    duzenlenecekOlay.OlayId = int.Parse(txtOlay.EditValue.ToString());
                    duzenlenecekOlay.OlayTarihi = txtOlayTarihi.DateTime;
                    duzenlenecekOlay.OlayYeriId = int.Parse(txtOlayYeri.EditValue.ToString());
                    duzenlenecekOlay.SiraNo = long.Parse(txtSiraNo.Text);
                    duzenlenecekOlay.TansifId = _tasnifId;
                }
                else
                {
                    throw new Exception("Kayıt bulunamadı");
                }
                db.Entry(duzenlenecekOlay).State = EntityState.Modified;
                db.SaveChanges();
            }
            Close();
        }
    }
}
