using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using ETS.Akislar.Istatistikler;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class MuzekkereIcmalAyarlari : Form
    {
        public MuzekkereIcmalAyarlari()
        {
            InitializeComponent();
            SetPersonel();
        }

        private void SetPersonel()
        {
            txtTanzimEden.Properties.Columns.Clear();
            txtTanzimEden.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtTanzimEden.Properties.DisplayMember = "TamIsim";
            txtTanzimEden.Properties.ValueMember = "Id";
            txtTanzimEden.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();

            txtTastikEden.Properties.Columns.Clear();
            txtTastikEden.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtTastikEden.Properties.DisplayMember = "TamIsim";
            txtTastikEden.Properties.ValueMember = "Id";
            txtTastikEden.Properties.DataSource = new ETSEntities().Personel.Where(x => x.Durum == 1).ToList();
        }

        private void btnIcmalleriGoster_Click(object sender, EventArgs e)
        {
            if (!validationProvider.Validate()) return;
            
            var icmalRaporIsleri = new IcmalRapor();

            var raporAylikIcmaller = new XtraReport();
            var raporYillikIcmal = new XtraReport();
            var raporYillikIcmaller = new XtraReport();

            switch (txtKarakol.Text)
            {
                case "Hepsi":
                    raporAylikIcmaller.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\AylikIcmalHepsi.repx");
                    break;
                case "Merkez":
                    raporAylikIcmaller.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\AylikIcmalMerkez.repx");
                    break;
                case "Kemer":raporAylikIcmaller.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\AylikIcmalKemer.repx");
                    break;
            }

            raporYillikIcmal.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\YillikIcmal.repx");
            raporYillikIcmaller.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\YillikIcmaller.repx");

            var aylikDataSource = icmalRaporIsleri.Aylik(int.Parse(txtYil.Text), "Hepsi", int.Parse(txtTanzimEden.EditValue.ToString()), int.Parse(txtTastikEden.EditValue.ToString()));
            var yillikDataSource = icmalRaporIsleri.Yillik(int.Parse(txtYil.Text), int.Parse(txtTanzimEden.EditValue.ToString()), int.Parse(txtTastikEden.EditValue.ToString()));
            var yilliklarDataSource = icmalRaporIsleri.Yilliklar(int.Parse(txtYil.Text));

            raporYillikIcmaller.DataSource = yilliklarDataSource;
            raporYillikIcmal.DataSource = yillikDataSource;
            raporAylikIcmaller.DataSource = aylikDataSource;

            raporAylikIcmaller.ShowRibbonPreview();
            raporYillikIcmal.ShowRibbonPreview();
            raporYillikIcmaller.ShowRibbonPreview();
        }

        private void MuzekkereIcmalAyarlari_Load(object sender, EventArgs e)
        {
            txtYil.EditValue = DateTime.Now.ToString("yyyy");
        }
    }
}