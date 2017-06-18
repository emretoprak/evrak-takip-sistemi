namespace ETS
{
    partial class YedekYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YedekYonetimi));
            this.rpageGelenEvraklar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnSimdiYedekle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeriAl = new DevExpress.XtraEditors.SimpleButton();
            this.lstYedekler = new DevExpress.XtraEditors.ImageListBoxControl();
            this.icoList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lstYedekler)).BeginInit();
            this.SuspendLayout();
            // 
            // rpageGelenEvraklar
            // 
            this.rpageGelenEvraklar.ImageAlign = DevExpress.Utils.HorzAlignment.Near;
            this.rpageGelenEvraklar.Name = "rpageGelenEvraklar";
            this.rpageGelenEvraklar.Text = "Gelen Evrak Ayarları";
            // 
            // btnSimdiYedekle
            // 
            this.btnSimdiYedekle.Image = ((System.Drawing.Image)(resources.GetObject("btnSimdiYedekle.Image")));
            this.btnSimdiYedekle.Location = new System.Drawing.Point(12, 12);
            this.btnSimdiYedekle.Name = "btnSimdiYedekle";
            this.btnSimdiYedekle.Size = new System.Drawing.Size(136, 46);
            this.btnSimdiYedekle.TabIndex = 11;
            this.btnSimdiYedekle.Text = "Yedekle";
            this.btnSimdiYedekle.Click += new System.EventHandler(this.btnSimdiYedekle_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriAl.Image")));
            this.btnGeriAl.Location = new System.Drawing.Point(12, 64);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(136, 46);
            this.btnGeriAl.TabIndex = 11;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // lstYedekler
            // 
            this.lstYedekler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstYedekler.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstYedekler.Appearance.Options.UseFont = true;
            this.lstYedekler.ImageList = this.icoList;
            this.lstYedekler.Location = new System.Drawing.Point(154, 12);
            this.lstYedekler.Name = "lstYedekler";
            this.lstYedekler.Size = new System.Drawing.Size(788, 368);
            this.lstYedekler.TabIndex = 12;
            this.lstYedekler.DoubleClick += new System.EventHandler(this.lstYedekler_DoubleClick);
            // 
            // icoList
            // 
            this.icoList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icoList.ImageStream")));
            this.icoList.TransparentColor = System.Drawing.Color.Transparent;
            this.icoList.Images.SetKeyName(0, "icoDB.png");
            // 
            // YedekYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 392);
            this.Controls.Add(this.lstYedekler);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnSimdiYedekle);
            this.Name = "YedekYonetimi";
            this.Text = "Yedek Yönetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YedekYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstYedekler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage rpageGelenEvraklar;
        private DevExpress.XtraEditors.SimpleButton btnSimdiYedekle;
        private DevExpress.XtraEditors.SimpleButton btnGeriAl;
        private DevExpress.XtraEditors.ImageListBoxControl lstYedekler;
        private System.Windows.Forms.ImageList icoList;
    }
}