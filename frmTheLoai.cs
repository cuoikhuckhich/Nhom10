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
    public partial class frmTheLoai : Form
    {
        DataTable tblTL;
        public frmTheLoai()
        {
            InitializeComponent();
        }
       
        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            txtMaloai.Enabled = false;
            loadDataGridView();

        }
        private void loadDataGridView()
        {
            string sql = "Select * from TheLoai";
            tblTL = Class.Functions.GetDataToTable(sql);
            DataGridView_TheLoai.DataSource = tblTL;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaloai.Text = "";
            txtTenloai.Text = "";
            txtMaloai.Enabled = true;
        }
        private void resetvalue()
        {
            txtMaloai.Text = "";
            txtTenloai.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap Mã thể loại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaloai.Focus();
                return;
            }
            if (txtTenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap Ten Thể Loại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenloai.Focus();
                return;
            }
            sql = "select Maloai from TheLoai Where Maloai=N'" + txtMaloai.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Thể Loại đã có ,bạn phải nhập mã khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaloai.Focus();
                txtMaloai.Text = "";
                return;
            }
            sql = "insert into TheLoai values('" + txtMaloai.Text + "','" + txtTenloai.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void DataGridView_TheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE TheLoai Where Maloai=N'" + txtMaloai.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
                resetvalue();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên thể loại ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenloai.Focus();
                return;
            }
            sql = "UPDATE TheLoai SET Maloai='" + txtMaloai.Text + "',Tenloai='" + txtTenloai.Text + "' Where (Maloai='" + txtMaloai.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaloai.Text = DataGridView_TheLoai.CurrentRow.Cells["Maloai"].Value.ToString();
            txtTenloai.Text = DataGridView_TheLoai.CurrentRow.Cells["Tenloai"].Value.ToString();
            txtMaloai.Enabled = false;
        }
    }
}
