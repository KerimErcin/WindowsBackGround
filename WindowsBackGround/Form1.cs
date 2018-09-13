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

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectedButton(btnHome.Width, btnHome.Left);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectedButton(btnHome.Width, btnHome.Left);
            Home home = new Home();
            pnlContainer.Controls.Clear();
            home.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(home);
            
        }

        public void SelectedButton(int width, int left)
        {
            pnlSelect.Left = left;
            pnlSelect.Width = width;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SelectedButton(btnSettings.Width, btnSettings.Left);
        }
    }
}
