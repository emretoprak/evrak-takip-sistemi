using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS.Akislar.Istatistikler;
using ETS.VeriKatmani;

namespace ETS
{
    public partial class OlayBilgileriOlayDagilimiAyarlari : Form
    {
        private string _tasnifBaslik;

        /// <summary>
        /// Initial işler
        /// </summary>
        public OlayBilgileriOlayDagilimiAyarlari()
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
        }

        /// <summary>
        /// Başlık verisini günceller
        /// </summary>
        private void BaslikGuncelle()
        {
            using (var db = new ETSEntities())
            {
                var txtTasnifBaslikData = db.Tasnifler.Select(s => s.Grup).Distinct().ToList();
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
            var olayBilgileriYillikDokum = new OlayBilgileriYillikDokum();
            var htmlTable = olayBilgileriYillikDokum.OlayDagilimi(lstRaporElemanlari.Items);
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "xls",
                FileName = "Olay Bilgileri Olay Dağılımı"
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
