using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ETS.RaporTasarlayicisi;

namespace ETS
{
    public partial class RaporSecimEkrani : Form
    {
        private readonly List<KeyValuePair<int, string>> _fileList = new List<KeyValuePair<int, string>>();

        public RaporSecimEkrani()
        {
            InitializeComponent();
        }

        private void RaporSecimEkrani_Load(object sender, EventArgs e)
        {
            cmbRaporlar.Properties.Items.Clear();
            var di = new DirectoryInfo(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Raporlar");
            var directories = di.GetFiles("*.repx", SearchOption.TopDirectoryOnly);
            var i = 0;
            foreach (var d in directories)
            {
                cmbRaporlar.Properties.Items.Add(d.Name);
                _fileList.Add(new KeyValuePair<int, string>(i, d.FullName));
                i ++;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider.Validate(cmbRaporlar)) return;
            if (!dxValidationProvider.Validate(cmbVeriler)) return;
            Close();
            new RaporDuzenle(_fileList[cmbRaporlar.SelectedIndex].Value, cmbVeriler.SelectedText).ShowDialog();
        }

        private void btnYeniRapor_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider.Validate(cmbVeriler)) return;
            new RaporDuzenle(null, cmbVeriler.SelectedText).ShowDialog();
        }

        private void cmbRaporlar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbVeriler_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}