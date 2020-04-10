using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace QLyBanHangQuanAo
{
    public partial class FrmChatLieu : Form
    {
        DataTable tblCL;
        public FrmChatLieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//nút thêm
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
            txtMachatlieu.Enabled = true;

        }
        private void resetvalue()
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }
        private  void loadDataGridView()
        {   string sql = "Select * from ChatLieu";
            tblCL = Class.Functions.GetDataToTable(sql);
            DataGridView_ChatLieu.DataSource = tblCL;
         }
        private void FrmChatLieu_Load(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = false;
            loadDataGridView();
        }

        private void DataGridView_ChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblCL.Rows.Count==0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }  
            if(txtMachatlieu.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(MessageBox.Show("Bạn có Muốn xóa bản ghi không?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                sql = "DELETE ChatLieu Where Machatlieu=N'" + txtMachatlieu.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
                resetvalue();
            }    
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtTenchatlieu.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn cần nhập tên chất liệu ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchatlieu.Focus();
                return;
            }    
             sql = "UPDATE ChatLieu SET Machatlieu='" + txtMachatlieu.Text + "',Tenchatlieu='" + txtTenchatlieu.Text + "' Where (Machatlieu='" + txtMachatlieu.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMachatlieu.Text.Trim().Length==0)
            {
                MessageBox.Show("Ban can nhap Ma Chat Lieu","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMachatlieu.Focus();
                return;
            }
            if (txtTenchatlieu.Text.Trim().Length==0)
            {
                MessageBox.Show("Ban can nhap Ten chat lieu","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTenchatlieu.Focus();
                return;
            }
            sql = "select Machatlieu from ChatLieu Where Machatlieu=N'" + txtMachatlieu.Text + "'";
            if(Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Chất Liệu đã có ,bạn phải nhập mã khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachatlieu.Focus();
                txtMachatlieu.Text = "";
                return;
            }    
            sql = "insert into Chatlieu values('" + txtMachatlieu.Text + "','" + txtTenchatlieu.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void DataGridView_ChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMachatlieu.Text = DataGridView_ChatLieu.CurrentRow.Cells["Machatlieu"].Value.ToString();
            txtTenchatlieu.Text = DataGridView_ChatLieu.CurrentRow.Cells["Tenchatlieu"].Value.ToString();
            txtMachatlieu.Enabled = false;
        }
    }
}
