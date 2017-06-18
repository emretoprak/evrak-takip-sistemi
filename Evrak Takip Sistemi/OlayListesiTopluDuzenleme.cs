using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class OlayListesiTopluDuzenleme : Form
    {
        private readonly Collection<long> _topluCiktilar;

        public OlayListesiTopluDuzenleme(Collection<long> topluCiktilar, string kolonAdi)
        {
            _topluCiktilar = topluCiktilar;
            InitializeComponent();
            SetPeriyot();
            SetPersonel();

            switch (kolonAdi)
            {
                case "PeriyotYili":
                    txtPeriyotYili.Enabled = true;
                    break;
                case "Periyotlar.Periyot":
                    txtPeriyot.Enabled = true;
                    break;
                case "Personel.AdiSoyadi":
                    txtPersonel1.Enabled = true;
                    break;
                case "Personel1.AdiSoyadi":
                    txtPersonel2.Enabled = true;
                    break;
                case "Personel2.AdiSoyadi":
                    txtPersonel3.Enabled = true;
                    break;
                case "Personel3.AdiSoyadi":
                    txtPersonel4.Enabled = true;
                    break;
            }
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

        private void btnDegisiklikleriKaydet_Click(object sender, EventArgs e)
        {
            using (var db = new ETSEntities())
            {
                var degistirilecekVeriler = (db.DaimiArastirmaTutanaklari.AsEnumerable()
                    .Select(r => new
                { r, list = _topluCiktilar })
                    .Where(@t => (@t.list.Contains(@t.r.Id)))
                    .Select(@t => @t.r)).ToList();

                foreach (var t in degistirilecekVeriler)
                {
                    if (!string.IsNullOrWhiteSpace(txtPeriyotYili.SelectedText))
                    {
                        t.PeriyotYili = Convert.ToInt32(txtPeriyotYili.Text);
                    }

                    if (txtPeriyot.EditValue != null && txtPeriyot.EditValue.ToString().Length < 5)
                    {
                        t.PeriyotId = int.Parse(txtPeriyot.EditValue.ToString());
                    }

                    if (txtPersonel1.EditValue != null && txtPersonel1.EditValue.ToString().Length < 5)
                    {
                        t.Personel1Id = int.Parse(txtPersonel1.EditValue.ToString());
                    }

                    if (txtPersonel2.EditValue != null && txtPersonel2.EditValue.ToString().Length < 5)
                    {
                        t.Personel2Id = int.Parse(txtPersonel2.EditValue.ToString());
                    }

                    if (txtPersonel3.EditValue != null && txtPersonel3.EditValue.ToString().Length < 5)
                    {
                        t.Personel3Id = int.Parse(txtPersonel3.EditValue.ToString());
                    }

                    if (txtPersonel4.EditValue != null && txtPersonel4.EditValue.ToString().Length < 5)
                    {
                        t.Personel4Id = int.Parse(txtPersonel4.EditValue.ToString());
                    }
                }

                degistirilecekVeriler.ForEach(p => db.Entry(p).State = EntityState.Modified);
                db.SaveChanges();

                Close();
            }
        }
    }
}
