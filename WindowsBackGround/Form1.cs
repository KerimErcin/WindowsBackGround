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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
