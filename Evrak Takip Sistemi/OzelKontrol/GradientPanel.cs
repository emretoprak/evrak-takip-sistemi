namespace ETS.OzelKontrol
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public partial class GradientPanel : Panel
    {
        private Color _mEndColor;
        private Color _mStartColor;

        public GradientPanel()
        {
            InitializeComponent();
            PaintGradient();
        }

        public Color PageStartColor
        {
            get
            {
                return _mStartColor;
            }
            set
            {
                _mStartColor = value;
                PaintGradient();
            }
        }

        public Color PageEndColor
        {
            get
            {
                return _mEndColor;
            }
            set
            {
                _mEndColor = value;
                PaintGradient();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void PaintGradient()
        {
            var gradBrush = new LinearGradientBrush(new Point(0, 0), new Point(Width, Height), PageStartColor, PageEndColor);

            var bmp = new Bitmap(Width, Height);

            var g = Graphics.FromImage(bmp);
            g.FillRectangle(gradBrush, new Rectangle(0, 0, Width, Height));
            BackgroundImage = bmp;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
