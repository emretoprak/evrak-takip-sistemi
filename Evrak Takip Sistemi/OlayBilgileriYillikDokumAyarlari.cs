using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS.Akislar.Istatistikler;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class OlayBilgileriYillikDokumAyarlari : Form
    {
        private string _tasnifBaslik;

        /// <summary>
        /// Initial işler
        /// </summary>
        public OlayBilgileriYillikDokumAyarlari()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form açılırken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Test_Load(object sender, EventArgs e)
        {
            BaslikGuncelle();
            txtYil.Text = DateTime.Now.ToString("yyyy");
        }

        /// <summary>
        /// Başlık verisini günceller
        /// </summary>
        private void BaslikGuncelle()
        {
            using (var db = new ETSEntities())
            {
                var txtTasnifBaslikData = db.Tasnifler.Select(s => s.Baslik).Distinct().ToList();
                txtTasnifBaslik.Properties.DataSource = txtTasnifBaslikData;
            }
        }

        /// <summary>
        /// Başlık listesi seçildiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtval1_EditValueChanged(object sender, EventArgs e)
        {
            _tasnifBaslik = txtTasnifBaslik.EditValue.ToString();
        }

        /// <summary>
        /// Seçili başlığı listeye ekler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaporaEkle_Click(object sender, EventArgs e)
        {
            if (_tasnifBaslik == null) return;
            if (lstRaporElemanlari.Items.Cast<object>().Contains(_tasnifBaslik)) return;
            lstRaporElemanlari.Items.Add(_tasnifBaslik,0);
            _tasnifBaslik = null;
        }

        /// <summary>
        /// Rapor hazırlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaporuHazirla_Click(object sender, EventArgs e)
        {
            var raporYili = int.Parse(txtYil.Text);
            var olayBilgileriYillikDokum = new OlayBilgileriYillikDokum();
            var htmlTable = olayBilgileriYillikDokum.YillikDokum(lstRaporElemanlari, raporYili);
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Olay Bilgileri Yıllık Döküm"
            };
            if (saveFile.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(saveFile.FileName, htmlTable, Encoding.UTF8);
            Close();
        }

        /// <summary>
        /// Listeye ekli tasnif i siler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            lstRaporElemanlari.Items.Remove(lstRaporElemanlari.SelectedItem);
        }

    }
}
