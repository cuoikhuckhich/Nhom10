using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyBanHangQuanAo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSanPham Sp = new FrmSanPham();
            Sp.MdiParent = this;
            Sp.Show();
           
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLoai TL = new frmTheLoai();
            TL.MdiParent = this;
            TL.Show();
        }

        private void cỡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCo Fc = new FrmCo();
            Fc.MdiParent = this;
            Fc.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChatLieu cl = new FrmChatLieu();
            cl.MdiParent = this;
            cl.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.Functions.Dungketnoi();
            Application.Exit();
        }
    }
}
