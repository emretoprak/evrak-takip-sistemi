namespace ETS.HataYakalama
{
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;
    using DevExpress.XtraEditors;
    using log4net;

    /// <summary>
    /// Hata yakalama sınıfı tüm hatalar bu sınıfa düşer
    /// </summary>
    public class ExceptionHandling
    {
        public static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Program içi özel yakalanmayan tüm hatalar bu fonksiyona gelir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // : Hata loglanıyor
            Log.Error(e.Exception);
            // : Hata gösteriliyor
            XtraMessageBox.Show(e.Exception.Message, "Bir Hata Oluştu ve log dosyasına kayıt edildi :", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
