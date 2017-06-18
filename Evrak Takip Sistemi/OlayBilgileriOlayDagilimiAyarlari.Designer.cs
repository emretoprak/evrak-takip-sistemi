namespace ETS
{
    partial class OlayBilgileriOlayDagilimiAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlayBilgileriOlayDagilimiAyarlari));
            this.txtTasnifBaslik = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnRaporaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lstRaporElemanlari = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRaporuHazirla = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstRaporElemanlari)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTasnifBaslik
            // 
            this.txtTasnifBaslik.Location = new System.Drawing.Point(5, 24);
            this.txtTasnifBaslik.Name = "txtTasnifBaslik";
            this.txtTasnifBaslik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTasnifBaslik.Properties.NullText = "Lütfen seçim yapınız";
            this.txtTasnifBaslik.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtTasnifBaslik.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTasnifBaslik.Size = new System.Drawing.Size(270, 20);
            this.txtTasnifBaslik.TabIndex = 0;
            this.txtTasnifBaslik.EditValueChanged += new System.EventHandler(this.txtval1_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnRaporaEkle);
            this.groupControl2.Controls.Add(this.txtTasnifBaslik);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(281, 85);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tasnifler";
            // 
            // btnRaporaEkle
            // 
            this.btnRaporaEkle.Location = new System.Drawing.Point(200, 50);
            this.btnRaporaEkle.Name = "btnRaporaEkle";
            this.btnRaporaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnRaporaEkle.TabIndex = 1;
            this.btnRaporaEkle.Text = "Rapora Ekle";
            this.btnRaporaEkle.Click += new System.EventHandler(this.btnRaporaEkle_Click);
            // 
            // lstRaporElemanlari
            // 
            this.lstRaporElemanlari.ImageList = this.imageList;
            this.lstRaporElemanlari.Location = new System.Drawing.Point(299, 12);
            this.lstRaporElemanlari.Name = "lstRaporElemanlari";
            this.lstRaporElemanlari.Size = new System.Drawing.Size(293, 159);
            this.lstRaporElemanlari.TabIndex = 5;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icoRaporList.png");
            // 
            // btnRaporuHazirla
            // 
            this.btnRaporuHazirla.Location = new System.Drawing.Point(507, 214);
            this.btnRaporuHazirla.Name = "btnRaporuHazirla";
            this.btnRaporuHazirla.Size = new System.Drawing.Size(85, 23);
            this.btnRaporuHazirla.TabIndex = 1;
            this.btnRaporuHazirla.Text = "Raporu Hazırla";
            this.btnRaporuHazirla.Click += new System.EventHandler(this.btnRaporuHazirla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(557, 177);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(30, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "-";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // OlayBilgileriOlayDagilimiAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 244);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnRaporuHazirla);
            this.Controls.Add(this.lstRaporElemanlari);
            this.Controls.Add(this.groupControl2);
            this.Name = "OlayBilgileriOlayDagilimiAyarlari";
            this.Text = "Tasnifler";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstRaporElemanlari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit txtTasnifBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnRaporaEkle;
        private DevExpress.XtraEditors.ImageListBoxControl lstRaporElemanlari;
        private System.Windows.Forms.ImageList imageList;
        private DevExpress.XtraEditors.SimpleButton btnRaporuHazirla;
        private DevExpress.XtraEditors.SimpleButton btnSil;

    }
}