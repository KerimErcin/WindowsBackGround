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
            this.pctrbx1 = new System.Windows.Forms.PictureBox();
            this.pctrbx2 = new System.Windows.Forms.PictureBox();
            this.pctrbx3 = new System.Windows.Forms.PictureBox();
            this.pctrbx4 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.btnColorPicker1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnColorPicker2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
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
            // pctrbx1
            // 
            this.pctrbx1.Location = new System.Drawing.Point(15, 13);
            this.pctrbx1.Name = "pctrbx1";
            this.pctrbx1.Size = new System.Drawing.Size(182, 51);
            this.pctrbx1.TabIndex = 0;
            this.pctrbx1.TabStop = false;
            // 
            // pctrbx2
            // 
            this.pctrbx2.Location = new System.Drawing.Point(15, 110);
            this.pctrbx2.Name = "pctrbx2";
            this.pctrbx2.Size = new System.Drawing.Size(182, 51);
            this.pctrbx2.TabIndex = 1;
            this.pctrbx2.TabStop = false;
            // 
            // pctrbx3
            // 
            this.pctrbx3.Location = new System.Drawing.Point(15, 207);
            this.pctrbx3.Name = "pctrbx3";
            this.pctrbx3.Size = new System.Drawing.Size(182, 51);
            this.pctrbx3.TabIndex = 2;
            this.pctrbx3.TabStop = false;
            // 
            // pctrbx4
            // 
            this.pctrbx4.Location = new System.Drawing.Point(15, 304);
            this.pctrbx4.Name = "pctrbx4";
            this.pctrbx4.Size = new System.Drawing.Size(182, 51);
            this.pctrbx4.TabIndex = 3;
            this.pctrbx4.TabStop = false;
            // 
            // btnColorPicker1
            // 
            this.btnColorPicker1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnColorPicker1.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btnColorPicker1.IconZoom = 50D;
            this.btnColorPicker1.IsTab = false;
            this.btnColorPicker1.Location = new System.Drawing.Point(151, 18);
            this.btnColorPicker1.Name = "btnColorPicker1";
            this.btnColorPicker1.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnColorPicker1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnColorPicker1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnColorPicker1.selected = false;
            this.btnColorPicker1.Size = new System.Drawing.Size(40, 40);
            this.btnColorPicker1.TabIndex = 1;
            this.btnColorPicker1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColorPicker1.Textcolor = System.Drawing.Color.White;
            this.btnColorPicker1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnColorPicker2
            // 
            this.btnColorPicker2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnColorPicker2.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btnColorPicker2.IconZoom = 50D;
            this.btnColorPicker2.IsTab = false;
            this.btnColorPicker2.Location = new System.Drawing.Point(151, 115);
            this.btnColorPicker2.Name = "btnColorPicker2";
            this.btnColorPicker2.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnColorPicker2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnColorPicker2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnColorPicker2.selected = false;
            this.btnColorPicker2.Size = new System.Drawing.Size(40, 40);
            this.btnColorPicker2.TabIndex = 4;
            this.btnColorPicker2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColorPicker2.Textcolor = System.Drawing.Color.White;
            this.btnColorPicker2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(151, 212);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(151, 310);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(40, 40);
            this.bunifuFlatButton2.TabIndex = 6;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(656, 378);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctrbx4;
        private System.Windows.Forms.PictureBox pctrbx3;
        private System.Windows.Forms.PictureBox pctrbx2;
        private System.Windows.Forms.PictureBox pctrbx1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private Bunifu.Framework.UI.BunifuFlatButton btnColorPicker1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnColorPicker2;
    }
}
