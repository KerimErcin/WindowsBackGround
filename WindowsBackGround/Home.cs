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
            string txtColor = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            SetPictureBoxColor(btnColorPicker1.Name, color, txtColor);
        }

        public void SetPictureBoxColor(string name, Color color, string rgb)
        {
            if (name == "btnColorPicker1")
            {
                pctrbx1.BackColor = color;
                lblRgb1.Text = "#" + rgb;
                lblRgb1.BackColor = Color.FromArgb(color.R, color.G, color.B);
            }
            else if (name == "btnColorPicker2")
            {
                pctrbx2.BackColor = color;
                lblRgb2.Text = "#" + rgb;
                lblRgb2.BackColor = Color.FromArgb(color.R, color.G, color.B);
            }
            else if (name == "btnColorPicker3")
            {
                pctrbx3.BackColor = color;
                lblRgb3.Text = "#" + rgb;
                lblRgb3.BackColor = Color.FromArgb(color.R, color.G, color.B);
            }
            else if (name == "btnColorPicker4")
            {
                pctrbx4.BackColor = color;
                lblRgb4.Text = "#" + rgb;
                lblRgb4.BackColor = Color.FromArgb(color.R, color.G, color.B);
            }
        }

        private void btnColorPicker2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            string txtColor = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            SetPictureBoxColor(btnColorPicker2.Name, color, txtColor);
        }

        private void btnColorPicker3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            string txtColor = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            SetPictureBoxColor(btnColorPicker3.Name, color, txtColor);
        }

        private void btnColorPicker4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            string txtColor = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            SetPictureBoxColor(btnColorPicker4.Name, color, txtColor);
        }
    }
}
