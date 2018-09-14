namespace WindowsBackGround
{
    partial class Home
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRgb4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRgb1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRgb3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRgb2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnColorPicker4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnColorPicker3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnColorPicker2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnColorPicker1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pctrbx4 = new System.Windows.Forms.PictureBox();
            this.pctrbx3 = new System.Windows.Forms.PictureBox();
            this.pctrbx2 = new System.Windows.Forms.PictureBox();
            this.pctrbx1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRandomColor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlPreview = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx1)).BeginInit();
            this.pnlPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRgb4);
            this.panel1.Controls.Add(this.lblRgb1);
            this.panel1.Controls.Add(this.lblRgb3);
            this.panel1.Controls.Add(this.lblRgb2);
            this.panel1.Controls.Add(this.btnColorPicker4);
            this.panel1.Controls.Add(this.btnColorPicker3);
            this.panel1.Controls.Add(this.btnColorPicker2);
            this.panel1.Controls.Add(this.btnColorPicker1);
            this.panel1.Controls.Add(this.pctrbx4);
            this.panel1.Controls.Add(this.pctrbx3);
            this.panel1.Controls.Add(this.pctrbx2);
            this.panel1.Controls.Add(this.pctrbx1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 378);
            this.panel1.TabIndex = 0;
            // 
            // lblRgb4
            // 
            this.lblRgb4.AutoSize = true;
            this.lblRgb4.BackColor = System.Drawing.Color.Transparent;
            this.lblRgb4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRgb4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRgb4.Location = new System.Drawing.Point(17, 326);
            this.lblRgb4.Name = "lblRgb4";
            this.lblRgb4.Size = new System.Drawing.Size(0, 15);
            this.lblRgb4.TabIndex = 10;
            // 
            // lblRgb1
            // 
            this.lblRgb1.AutoSize = true;
            this.lblRgb1.BackColor = System.Drawing.Color.Transparent;
            this.lblRgb1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRgb1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRgb1.Location = new System.Drawing.Point(17, 35);
            this.lblRgb1.Name = "lblRgb1";
            this.lblRgb1.Size = new System.Drawing.Size(0, 15);
            this.lblRgb1.TabIndex = 7;
            // 
            // lblRgb3
            // 
            this.lblRgb3.AutoSize = true;
            this.lblRgb3.BackColor = System.Drawing.Color.Transparent;
            this.lblRgb3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRgb3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRgb3.Location = new System.Drawing.Point(17, 230);
            this.lblRgb3.Name = "lblRgb3";
            this.lblRgb3.Size = new System.Drawing.Size(0, 15);
            this.lblRgb3.TabIndex = 9;
            // 
            // lblRgb2
            // 
            this.lblRgb2.AutoSize = true;
            this.lblRgb2.BackColor = System.Drawing.Color.Transparent;
            this.lblRgb2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRgb2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRgb2.Location = new System.Drawing.Point(17, 132);
            this.lblRgb2.Name = "lblRgb2";
            this.lblRgb2.Size = new System.Drawing.Size(0, 15);
            this.lblRgb2.TabIndex = 8;
            // 
            // btnColorPicker4
            // 
            this.btnColorPicker4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnColorPicker4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnColorPicker4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorPicker4.BorderRadius = 5;
            this.btnColorPicker4.ButtonText = "";
            this.btnColorPicker4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorPicker4.DisabledColor = System.Drawing.Color.Gray;
            this.btnColorPicker4.Iconcolor = System.Drawing.Color.Transparent;
            this.btnColorPicker4.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnColorPicker4.Iconimage")));
            this.btnColorPicker4.Iconimage_right = null;
            this.btnColorPicker4.Iconimage_right_Selected = null;
            this.btnColorPicker4.Iconimage_Selected = null;
            this.btnColorPicker4.IconMarginLeft = 0;
            this.btnColorPicker4.IconMarginRight = 0;
            this.btnColorPicker4.IconRightVisible = true;
            this.btnColorPicker4.IconRightZoom = 0D;
            this.btnColorPicker4.IconVisible = true;
            this.btnColorPicker4.IconZoom = 45D;
            this.btnColorPicker4.IsTab = false;
            this.btnColorPicker4.Location = new System.Drawing.Point(155, 316);
            this.btnColorPicker4.Name = "btnColorPicker4";
            this.btnColorPicker4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnColorPicker4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnColorPicker4.OnHoverTextColor = System.Drawing.Color.White;
            this.btnColorPicker4.selected = false;
            this.btnColorPicker4.Size = new System.Drawing.Size(35, 35);
            this.btnColorPicker4.TabIndex = 6;
            this.btnColorPicker4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColorPicker4.Textcolor = System.Drawing.Color.White;
            this.btnColorPicker4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorPicker4.Click += new System.EventHandler(this.btnColorPicker4_Click);
            // 
            // btnColorPicker3
            // 
            this.btnColorPicker3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnColorPicker3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnColorPicker3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorPicker3.BorderRadius = 5;
            this.btnColorPicker3.ButtonText = "";
            this.btnColorPicker3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorPicker3.DisabledColor = System.Drawing.Color.Gray;
            this.btnColorPicker3.Iconcolor = System.Drawing.Color.Transparent;
            this.btnColorPicker3.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnColorPicker3.Iconimage")));
            this.btnColorPicker3.Iconimage_right = null;
            this.btnColorPicker3.Iconimage_right_Selected = null;
            this.btnColorPicker3.Iconimage_Selected = null;
            this.btnColorPicker3.IconMarginLeft = 0;
            this.btnColorPicker3.IconMarginRight = 0;
            this.btnColorPicker3.IconRightVisible = true;
            this.btnColorPicker3.IconRightZoom = 0D;
            this.btnColorPicker3.IconVisible = true;
            this.btnColorPicker3.IconZoom = 45D;
            this.btnColorPicker3.IsTab = false;
            this.btnColorPicker3.Location = new System.Drawing.Point(155, 219);
            this.btnColorPicker3.Name = "btnColorPicker3";
            this.btnColorPicker3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnColorPicker3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnColorPicker3.OnHoverTextColor = System.Drawing.Color.White;
            this.btnColorPicker3.selected = false;
            this.btnColorPicker3.Size = new System.Drawing.Size(35, 35);
            this.btnColorPicker3.TabIndex = 5;
            this.btnColorPicker3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColorPicker3.Textcolor = System.Drawing.Color.White;
            this.btnColorPicker3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorPicker3.Click += new System.EventHandler(this.btnColorPicker3_Click);
            // 
            // btnColorPicker2
            // 
            this.btnColorPicker2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnColorPicker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnColorPicker2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorPicker2.BorderRadius = 5;
            this.btnColorPicker2.ButtonText = "";
            this.btnColorPicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorPicker2.DisabledColor = System.Drawing.Color.Gray;
            this.btnColorPicker2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnColorPicker2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnColorPicker2.Iconimage")));
            this.btnColorPicker2.Iconimage_right = null;
            this.btnColorPicker2.Iconimage_right_Selected = null;
            this.btnColorPicker2.Iconimage_Selected = null;
            this.btnColorPicker2.IconMarginLeft = 0;
            this.btnColorPicker2.IconMarginRight = 0;
            this.btnColorPicker2.IconRightVisible = true;
            this.btnColorPicker2.IconRightZoom = 0D;
            this.btnColorPicker2.IconVisible = true;
            this.btnColorPicker2.IconZoom = 45D;
            this.btnColorPicker2.IsTab = false;
            this.btnColorPicker2.Location = new System.Drawing.Point(155, 122);
            this.btnColorPicker2.Name = "btnColorPicker2";
            this.btnColorPicker2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnColorPicker2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnColorPicker2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnColorPicker2.selected = false;
            this.btnColorPicker2.Size = new System.Drawing.Size(35, 35);
            this.btnColorPicker2.TabIndex = 4;
            this.btnColorPicker2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColorPicker2.Textcolor = System.Drawing.Color.White;
            this.btnColorPicker2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorPicker2.Click += new System.EventHandler(this.btnColorPicker2_Click);
            // 
            // btnColorPicker1
            // 
            this.btnColorPicker1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnColorPicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnColorPicker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorPicker1.BorderRadius = 5;
            this.btnColorPicker1.ButtonText = "";
            this.btnColorPicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorPicker1.DisabledColor = System.Drawing.Color.Gray;
            this.btnColorPicker1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnColorPicker1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnColorPicker1.Iconimage")));
            this.btnColorPicker1.Iconimage_right = null;
            this.btnColorPicker1.Iconimage_right_Selected = null;
            this.btnColorPicker1.Iconimage_Selected = null;
            this.btnColorPicker1.IconMarginLeft = 0;
            this.btnColorPicker1.IconMarginRight = 0;
            this.btnColorPicker1.IconRightVisible = true;
            this.btnColorPicker1.IconRightZoom = 0D;
            this.btnColorPicker1.IconVisible = true;
            this.btnColorPicker1.IconZoom = 45D;
            this.btnColorPicker1.IsTab = false;
            this.btnColorPicker1.Location = new System.Drawing.Point(156, 25);
            this.btnColorPicker1.Name = "btnColorPicker1";
            this.btnColorPicker1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnColorPicker1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnColorPicker1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnColorPicker1.selected = false;
            this.btnColorPicker1.Size = new System.Drawing.Size(35, 35);
            this.btnColorPicker1.TabIndex = 1;
            this.btnColorPicker1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColorPicker1.Textcolor = System.Drawing.Color.White;
            this.btnColorPicker1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorPicker1.Click += new System.EventHandler(this.btnColorPicker1_Click);
            // 
            // pctrbx4
            // 
            this.pctrbx4.Location = new System.Drawing.Point(15, 308);
            this.pctrbx4.Name = "pctrbx4";
            this.pctrbx4.Size = new System.Drawing.Size(182, 51);
            this.pctrbx4.TabIndex = 3;
            this.pctrbx4.TabStop = false;
            // 
            // pctrbx3
            // 
            this.pctrbx3.Location = new System.Drawing.Point(15, 211);
            this.pctrbx3.Name = "pctrbx3";
            this.pctrbx3.Size = new System.Drawing.Size(182, 51);
            this.pctrbx3.TabIndex = 2;
            this.pctrbx3.TabStop = false;
            // 
            // pctrbx2
            // 
            this.pctrbx2.Location = new System.Drawing.Point(15, 114);
            this.pctrbx2.Name = "pctrbx2";
            this.pctrbx2.Size = new System.Drawing.Size(182, 51);
            this.pctrbx2.TabIndex = 1;
            this.pctrbx2.TabStop = false;
            // 
            // pctrbx1
            // 
            this.pctrbx1.Location = new System.Drawing.Point(15, 17);
            this.pctrbx1.Name = "pctrbx1";
            this.pctrbx1.Size = new System.Drawing.Size(182, 51);
            this.pctrbx1.TabIndex = 0;
            this.pctrbx1.TabStop = false;
            // 
            // colorDialog1
            // 
            this.colorDialog1.SolidColorOnly = true;
            // 
            // btnRandomColor
            // 
            this.btnRandomColor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnRandomColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnRandomColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandomColor.BorderRadius = 5;
            this.btnRandomColor.ButtonText = "Random Color";
            this.btnRandomColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandomColor.DisabledColor = System.Drawing.Color.Gray;
            this.btnRandomColor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRandomColor.Iconimage = null;
            this.btnRandomColor.Iconimage_right = null;
            this.btnRandomColor.Iconimage_right_Selected = null;
            this.btnRandomColor.Iconimage_Selected = null;
            this.btnRandomColor.IconMarginLeft = 0;
            this.btnRandomColor.IconMarginRight = 0;
            this.btnRandomColor.IconRightVisible = true;
            this.btnRandomColor.IconRightZoom = 0D;
            this.btnRandomColor.IconVisible = true;
            this.btnRandomColor.IconZoom = 90D;
            this.btnRandomColor.IsTab = false;
            this.btnRandomColor.Location = new System.Drawing.Point(231, 219);
            this.btnRandomColor.Name = "btnRandomColor";
            this.btnRandomColor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.btnRandomColor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.btnRandomColor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRandomColor.selected = false;
            this.btnRandomColor.Size = new System.Drawing.Size(168, 39);
            this.btnRandomColor.TabIndex = 3;
            this.btnRandomColor.Text = "Random Color";
            this.btnRandomColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRandomColor.Textcolor = System.Drawing.Color.White;
            this.btnRandomColor.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandomColor.Click += new System.EventHandler(this.btnRandomColor_Click);
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPreview.BackgroundImage")));
            this.pnlPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPreview.Controls.Add(this.bunifuCustomLabel1);
            this.pnlPreview.Controls.Add(this.bunifuCircleProgressbar1);
            this.pnlPreview.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlPreview.GradientBottomRight = System.Drawing.Color.White;
            this.pnlPreview.GradientTopLeft = System.Drawing.Color.White;
            this.pnlPreview.GradientTopRight = System.Drawing.Color.White;
            this.pnlPreview.Location = new System.Drawing.Point(231, 17);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Quality = 10;
            this.pnlPreview.Size = new System.Drawing.Size(393, 177);
            this.pnlPreview.TabIndex = 4;
            this.pnlPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPreview_Paint);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 50;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 10;
            this.bunifuCircleProgressbar1.LineThickness = 2;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(144, 40);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(100, 100);
            this.bunifuCircleProgressbar1.TabIndex = 0;
            this.bunifuCircleProgressbar1.Value = 50;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Preview";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.btnRandomColor);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(656, 378);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx1)).EndInit();
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pctrbx4;
        public System.Windows.Forms.PictureBox pctrbx3;
        public System.Windows.Forms.PictureBox pctrbx2;
        public System.Windows.Forms.PictureBox pctrbx1;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public Bunifu.Framework.UI.BunifuFlatButton btnColorPicker1;
        public Bunifu.Framework.UI.BunifuFlatButton btnColorPicker4;
        public Bunifu.Framework.UI.BunifuFlatButton btnColorPicker3;
        public Bunifu.Framework.UI.BunifuFlatButton btnColorPicker2;
        public Bunifu.Framework.UI.BunifuCustomLabel lblRgb1;
        public Bunifu.Framework.UI.BunifuCustomLabel lblRgb2;
        public Bunifu.Framework.UI.BunifuCustomLabel lblRgb4;
        public Bunifu.Framework.UI.BunifuCustomLabel lblRgb3;
        private Bunifu.Framework.UI.BunifuFlatButton btnRandomColor;
        public Bunifu.Framework.UI.BunifuGradientPanel pnlPreview;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
