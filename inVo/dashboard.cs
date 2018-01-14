using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inVo
{
    public partial class dashboard : Form
    {

        static void Dashboard(string[] args)
        {
            try
            {

            }
            
            catch(Exception)
            {
                throw;
            }
        }

        public dashboard()
        {
            InitializeComponent();
            minimize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            close.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void inVo_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventory_panel.Visible = true;
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            minimize.BackgroundImage = new Bitmap(inVo.Properties.Resources.h_minimize);
            label1.Text = "minimize_MouseHover";
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackgroundImage = new Bitmap(inVo.Properties.Resources.minimize);
            label1.Text = "minimize_MouseLeave";
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackgroundImage = new Bitmap(inVo.Properties.Resources.h_close);
            label1.Text = "close_MouseHover";
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackgroundImage = new Bitmap(inVo.Properties.Resources.close);
            label1.Text = "close_MouseLeave";
        }

    }
}
