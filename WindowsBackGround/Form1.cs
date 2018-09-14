using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBackGround
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Home home = new Home();
        Settings settings = new Settings();

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectedButton(btnHome.Width, btnHome.Left);
            DocksControl(btnHome.Name, home, settings);
            PictureBoxAndLabelLoader();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectedButton(btnHome.Width, btnHome.Left);
            pnlContainer.Controls.Clear();
            DocksControl(btnHome.Name, home, settings);
        }

        public void SelectedButton(int width, int left)
        {
            pnlSelect.Left = left;
            pnlSelect.Width = width;
        }

        public void DocksControl(string name, Home home, Settings settings)
        {
            pnlContainer.Controls.Clear();
            if (name == "btnHome")
            {
                home.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(home);
            }
            else
            {
                settings.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(settings);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SelectedButton(btnSettings.Width, btnSettings.Left);
            DocksControl(btnSettings.Name, home, settings);
        }

        public void PictureBoxAndLabelLoader()
        {
            //Picturebox BackColor
            home.pctrbx1.BackColor = Properties.Settings.Default.color1;
            home.pctrbx2.BackColor = Properties.Settings.Default.color2;
            home.pctrbx3.BackColor = Properties.Settings.Default.color3;
            home.pctrbx4.BackColor = Properties.Settings.Default.color4;
            //Label Text
            home.lblRgb1.Text = "#" + Convert.ToString(Properties.Settings.Default.color1.ToArgb().ToString("X6"));
            home.lblRgb2.Text = "#" + Convert.ToString(Properties.Settings.Default.color2.ToArgb().ToString("X6"));
            home.lblRgb3.Text = "#" + Convert.ToString(Properties.Settings.Default.color3.ToArgb().ToString("X6"));
            home.lblRgb4.Text = "#" + Convert.ToString(Properties.Settings.Default.color4.ToArgb().ToString("X6"));
            //Label BackColor
            home.lblRgb1.BackColor = Properties.Settings.Default.color1;
            home.lblRgb2.BackColor = Properties.Settings.Default.color2;
            home.lblRgb3.BackColor = Properties.Settings.Default.color3;
            home.lblRgb4.BackColor = Properties.Settings.Default.color4;
            //GradiantPanel Load
            home.pnlPreview.GradientBottomLeft = Properties.Settings.Default.color1;
            home.pnlPreview.GradientBottomRight = Properties.Settings.Default.color2;
            home.pnlPreview.GradientTopLeft = Properties.Settings.Default.color3;
            home.pnlPreview.GradientTopRight = Properties.Settings.Default.color4;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.color1 = home.pctrbx1.BackColor;
            Properties.Settings.Default.color2 = home.pctrbx2.BackColor;
            Properties.Settings.Default.color3 = home.pctrbx3.BackColor;
            Properties.Settings.Default.color4 = home.pctrbx4.BackColor;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}
