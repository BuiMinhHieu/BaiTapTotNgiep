using BuiMinhHieu_CDTH17.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiMinhHieu_CDTH17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dOITUONGMGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOITUONGMG frm = new DOITUONGMG();
            frm.Show();
        }

        private void mUCTHUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MUCTHU frm1 = new MUCTHU();
            frm1.Show();
        }

        private void lOPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LOP frm2 = new LOP();
            frm2.Show();
        }

        private void hOCSINHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOCSINH frm3 = new HOCSINH();
            frm3.Show();
                 
        }

        private void bIENLAIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BIENLAI frm4 = new BIENLAI();
            frm4.Show();
        }

        private void tHEODOILICHANToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            THEODOILICHAN frm5 = new THEODOILICHAN();
            frm5.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500, "Thông Báo", "Bấm đúp để mở chương trình", ToolTipIcon.Info);
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void mởChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        

       
    }
}
