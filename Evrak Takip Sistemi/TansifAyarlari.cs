using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class TasnifAyarlari : Form
    {
        private int _tasnifId;

        public TasnifAyarlari()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            BaslikGuncelle();
        }

        private void BaslikGuncelle()
        {
            using (var db = new ETSEntities())
            {
                var txtTasnifBaslikData = db.Tasnifler.Select(s => s.Baslik).Distinct().ToList();
                txtTasnifBaslik.Properties.DataSource = txtTasnifBaslikData;
            }
        }

        private void txtval1_EditValueChanged(object sender, EventArgs e)
        {
            var txtTasnif = sender as DevExpress.XtraEditors.LookUpEdit;
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
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void txtval2_EditValueChanged(object sender, EventArgs e)
        {
            var txtTasnif = sender as DevExpress.XtraEditors.LookUpEdit;
            if (txtTasnif == null) return;
            using (var db = new ETSEntities())
            {
                var txtTasnifSucData = db.Tasnifler.Where(w => w.Baslik.Equals(txtTasnifBaslik.Text) && w.AltBaslik.Equals(txtTasnif.Text)).Select(s => s.Suc).Distinct().ToList();
                txtTasnifSuc.Properties.DataSource = txtTasnifSucData;
                txtTasnifSuc.Enabled = true;
                txtTasnifGrup.Enabled = false;
                txtTasnifGrup.EditValue = null;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void txtval3_EditValueChanged(object sender, EventArgs e)
        {
            var txtTasnif = sender as DevExpress.XtraEditors.LookUpEdit;
            if (txtTasnif == null) return;
            using (var db = new ETSEntities())
            {
                var txtTasnifGrupData = db.Tasnifler.Where(w => w.Baslik.Equals(txtTasnifBaslik.Text) && w.AltBaslik.Equals(txtTasnifAltBaslik.Text) && w.Suc.Equals(txtTasnif.Text)).Select(s => s.Grup).Distinct().ToList();
                txtTasnifGrup.Properties.DataSource = txtTasnifGrupData;
                txtTasnifGrup.Enabled = true;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void txtval4_EditValueChanged(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                var tasnif = db.Tasnifler.SingleOrDefault(w => w.Baslik.Equals(txtTasnifBaslik.Text) && w.AltBaslik.Equals(txtTasnifAltBaslik.Text) && w.Suc.Equals(txtTasnifSuc.Text) && w.Grup.Equals(txtTasnifGrup.Text));
                if (tasnif != null) _tasnifId = tasnif.Id;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;
            
            using (var db = new ETSEntities())
            {
                db.Tasnifler.Add(new Tasnifler
                {
                    AltBaslik = txtAltBaslik.Text,
                    Baslik = txtBaslik.Text,
                    Grup = txtGrup.Text,
                    KanunMaddesi = txtKanunMaddesi.Text,
                    Suc = txtSuc.Text
                });

                db.SaveChanges();
            }

            FormuTemizle();
            BaslikGuncelle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (_tasnifId <= 0) return;
            using (var db = new ETSEntities())
            {
                var tasnif = db.Tasnifler.SingleOrDefault(s => s.Id == _tasnifId);
                if (tasnif == null) return;

                txtAltBaslik.Text = tasnif.AltBaslik;
                txtBaslik.Text = tasnif.Baslik;
                txtGrup.Text = tasnif.Grup;
                txtKanunMaddesi.Text = tasnif.KanunMaddesi;
                txtSuc.Text = tasnif.Suc;
            }
            btnEkle.Visible = false;
            btnKaydet.Visible = true;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                var tasnif = db.Tasnifler.SingleOrDefault(s => s.Id == _tasnifId);
                if (tasnif == null) return;
                
                tasnif.AltBaslik = txtAltBaslik.Text;
                tasnif.Baslik = txtBaslik.Text;
                tasnif.Grup = txtGrup.Text;
                tasnif.KanunMaddesi = txtKanunMaddesi.Text;
                tasnif.Suc = txtSuc.Text;
                
                db.Entry(tasnif).State = EntityState.Modified;
                db.SaveChanges();
            }

            FormuTemizle();
            BaslikGuncelle();
            btnEkle.Visible = true;
            btnKaydet.Visible = false;
        }

        private void FormuTemizle()
        {
            txtAltBaslik.Text = null;
            txtBaslik.Text = null;
            txtGrup.Text = null;
            txtKanunMaddesi.Text = null;
            txtSuc.Text = null;
            txtTasnifAltBaslik.EditValue = null;
            txtTasnifBaslik.EditValue = null;
            txtTasnifGrup.EditValue = null;
            txtKanunMaddesi.EditValue = null;
            txtSuc.EditValue = null;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                var tasnif = db.Tasnifler.SingleOrDefault(s => s.Id == _tasnifId);
                if (tasnif == null) return;
                db.Entry(tasnif).State = EntityState.Deleted;
                db.SaveChanges();
                
            }

            FormuTemizle();
            BaslikGuncelle();
        }
    }
}
