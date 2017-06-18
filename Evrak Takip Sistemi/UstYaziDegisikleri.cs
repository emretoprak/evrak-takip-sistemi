using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class UstYaziDegisikleri : Form
    {
        private readonly Collection<long> _topluCiktilar;

        public UstYaziDegisikleri(Collection<long> topluCiktilar)
        {
            _topluCiktilar = topluCiktilar;
            InitializeComponent();
            SetPeriyot();
            SetPersonel();
            txtBaslik.Properties.DataSource = new ETSEntities().Baslik.ToList();
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
            txtPersonel1.Properties.DataSource = new ETSEntities().Personel.ToList();

            txtPersonel2.Properties.Columns.Clear();
            txtPersonel2.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel2.Properties.DisplayMember = "TamIsim";
            txtPersonel2.Properties.ValueMember = "Id";
            txtPersonel2.Properties.DataSource = new ETSEntities().Personel.ToList();

            txtPersonel3.Properties.Columns.Clear();
            txtPersonel3.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel3.Properties.DisplayMember = "TamIsim";
            txtPersonel3.Properties.ValueMember = "Id";
            txtPersonel3.Properties.DataSource = new ETSEntities().Personel.ToList();

            txtPersonel4.Properties.Columns.Clear();
            txtPersonel4.Properties.Columns.Add(new LookUpColumnInfo
            {
                FieldName = "TamIsim",
                Caption = "Personel"
            });
            txtPersonel4.Properties.DisplayMember = "TamIsim";
            txtPersonel4.Properties.ValueMember = "Id";
            txtPersonel4.Properties.DataSource = new ETSEntities().Personel.ToList();
        }

        private void btnDegisiklikleriUygula_Click(object sender, EventArgs e)
        {
            var ustYazi = new XtraReport();
            var tutanak = new XtraReport();
            ustYazi.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\UstYazi.repx");
            tutanak.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\Tutanak.repx");

            var daimiCikti = (new ETSEntities().DaimiArastirmaTutanaklari.AsEnumerable().Select(r => new {r, list = _topluCiktilar}).Where(@t => (@t.list.Contains(@t.r.Id))).Select(@t => @t.r)).ToList();

            foreach (var t in daimiCikti)
            {
                if (txtBaslik.EditValue.ToString().Length < 5)
                {
                    var id = int.Parse(txtBaslik.EditValue.ToString());
                    t.Baslik = new ETSEntities().Baslik.SingleOrDefault(x => x.Id == id);
                }

                if (!string.IsNullOrWhiteSpace(txtPeriyotYili.SelectedText))
                {
                    t.PeriyotYili = Convert.ToInt32(txtPeriyotYili.Text);
                }

                if (txtPeriyot.EditValue != null && txtPeriyot.EditValue.ToString().Length < 5)
                {
                    var id = int.Parse(txtPeriyot.EditValue.ToString());
                    t.Periyotlar = new ETSEntities().Periyotlar.SingleOrDefault(x => x.Id == id);
                }

                if (txtPersonel1.EditValue != null && txtPersonel1.EditValue.ToString().Length < 5)
                {
                    var id = int.Parse(txtPersonel1.EditValue.ToString());
                    t.Personel = new ETSEntities().Personel.SingleOrDefault(x => x.Id == id);
                    t.Personel1Id = id;
                }

                if (txtPersonel2.EditValue != null && txtPersonel2.EditValue.ToString().Length < 5)
                {
                    var id = int.Parse(txtPersonel2.EditValue.ToString());
                    t.Personel1 = new ETSEntities().Personel.SingleOrDefault(x => x.Id == id);
                    t.Personel2Id = id;
                }

                if (txtPersonel3.EditValue != null && txtPersonel3.EditValue.ToString().Length < 5)
                {
                    var id = int.Parse(txtPersonel3.EditValue.ToString());
                    t.Personel2 = new ETSEntities().Personel.SingleOrDefault(x => x.Id == id);
                    t.Personel3Id = id;
                }

                if (txtPersonel4.EditValue != null && txtPersonel4.EditValue.ToString().Length < 5)
                {
                    var id = int.Parse(txtPersonel4.EditValue.ToString());
                    t.Personel3 = new ETSEntities().Personel.SingleOrDefault(x => x.Id == id);
                    t.Personel4Id = id;
                }
            }

            ustYazi.DataSource = daimiCikti;
            ustYazi.ShowRibbonPreview();

            foreach (var t in daimiCikti.Where(t => t.Personel3Id == null && t.Personel4Id == null))
            {
                tutanak.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\Tutanak2Imza.repx");
            }

            foreach (var t in daimiCikti.Where(t => t.Personel3Id != null && t.Personel4Id == null))
            {
                tutanak.LoadLayout(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar\\Tutanak3Imza.repx");
            }

            tutanak.DataSource = daimiCikti;
            tutanak.ShowRibbonPreview();

            Close();
        }
    }
}