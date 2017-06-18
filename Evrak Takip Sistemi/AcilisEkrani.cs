using System;
using DevExpress.XtraSplashScreen;

namespace ETS
{
    public partial class AcilisEkrani : SplashScreen
    {
        public enum SplashScreenCommand
        {
        }

        public AcilisEkrani()
        {
            InitializeComponent();
        }

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }
    }
}