using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ETS
{
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.emretoprak.com");
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Bayrakları bayrak yapan üstündeki kandır \nToprak eğer uğrunda ölen varsa vatandır.");
        }
    }
}
