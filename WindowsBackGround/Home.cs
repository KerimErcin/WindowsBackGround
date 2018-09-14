using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBackGround
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnColorPicker1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            string txtColor = Convert.ToString(colorDialog1.Color.ToArgb().ToString("X6"));
            SetPictureBoxColor(btnColorPicker1.Name, color, txtColor);
        }

        public void SetPictureBoxColor(string name, Color color, string rgb)
        {
            if (name == "btnColorPicker1")
            {
                pctrbx1.BackColor = color;
                lblRgb1.Text = "#" + rgb;
                lblRgb1.BackColor = Color.FromArgb(color.A, color.R, color.G, color.B);
                pnlPreview.GradientBottomLeft = color;
            }
            else if (name == "btnColorPicker2")
            {
                pctrbx2.BackColor = color;
                lblRgb2.Text = "#" + rgb;
                lblRgb2.BackColor = Color.FromArgb(color.R, color.G, color.B);
                pnlPreview.GradientBottomRight = color;
            }
            else if (name == "btnColorPicker3")
            {
                pctrbx3.BackColor = color;
                lblRgb3.Text = "#" + rgb;
                lblRgb3.BackColor = Color.FromArgb(color.R, color.G, color.B);
                pnlPreview.GradientTopLeft = color;
            }
            else if (name == "btnColorPicker4")
            {
                pctrbx4.BackColor = color;
                lblRgb4.Text = "#" + rgb;
                lblRgb4.BackColor = Color.FromArgb(color.R, color.G, color.B);
                pnlPreview.GradientTopRight = color;
            }
        }

        private void btnColorPicker2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            string txtColor = Convert.ToString(colorDialog1.Color.ToArgb().ToString("X6"));
            SetPictureBoxColor(btnColorPicker2.Name, color, txtColor);
        }

        private void btnColorPicker3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            string txtColor = Convert.ToString(colorDialog1.Color.ToArgb().ToString("X6"));
            SetPictureBoxColor(btnColorPicker3.Name, color, txtColor);
        }

        private void btnColorPicker4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            string txtColor = Convert.ToString(colorDialog1.Color.ToArgb().ToString("X6"));
            SetPictureBoxColor(btnColorPicker4.Name, color, txtColor);
        }

        private void btnRandomColor_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Color test = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            //
            pctrbx1.BackColor = test;
            lblRgb1.BackColor = test;
            lblRgb1.Text = "#" + Convert.ToString(test.ToArgb().ToString("X6"));
            //
            Color test2 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            //
            pctrbx2.BackColor = test2;
            lblRgb2.BackColor = test2;
            lblRgb2.Text = "#" + Convert.ToString(test2.ToArgb().ToString("X6"));
            //
            Color test3 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            //
            pctrbx3.BackColor = test3;
            lblRgb3.BackColor = test3;
            lblRgb3.Text = "#" + Convert.ToString(test3.ToArgb().ToString("X6"));
            //
            Color test4 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            //
            pctrbx4.BackColor = test4;
            lblRgb4.BackColor = test4;
            lblRgb4.Text = "#" + Convert.ToString(test4.ToArgb().ToString("X6"));
            //Preview Loader
            pnlPreview.GradientBottomLeft = pctrbx1.BackColor;
            pnlPreview.GradientBottomRight = pctrbx2.BackColor;
            pnlPreview.GradientTopLeft = pctrbx3.BackColor;
            pnlPreview.GradientTopRight = pctrbx4.BackColor;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pnlPreview_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
