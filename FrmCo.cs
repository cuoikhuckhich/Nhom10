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

    public partial class FrmCo : Form
    {
        DataTable tblCo;
        public FrmCo()
        {
            InitializeComponent();
        }
    
        private void loadDataGridView()
        {
            string sql = "Select * from Co";
            tblCo = Class.Functions.GetDataToTable(sql);
            DataGridView_Co.DataSource = tblCo;
           
        }

        private void FrmCo_Load(object sender, EventArgs e)
        {
            txtMaco.Enabled = false;
            loadDataGridView();

        }

        private void DataGridView_Co_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaco.Text = "";
            txtTenco.Text = "";
            txtMaco.Enabled = true;
        }
        private void resetvalue()
        {
            txtMaco.Text = "";
            txtTenco.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCo.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaco.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          /*  if (txtTenco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên cỡ ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenco.Focus();
                return;
            }*/
            sql = "UPDATE Co SET Maco=N'" + txtMaco.Text.Trim() + "',Tenco=N'" + txtTenco.Text.Trim() + "' Where (Maco=N'" + txtMaco.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMaco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap Ma Co", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaco.Focus();
                return;
            }
            if (txtTenco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap Ten cỡ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenco.Focus();
                return;
            }
            sql = "select Maco from Co Where Maco=N'" + txtMaco.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Cỡ đã có ,bạn phải nhập mã khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaco.Focus();
                txtMaco.Text = "";
                return;
            }
            sql = "insert into Co values('" + txtMaco.Text + "','" + txtTenco.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCo.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaco.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Co Where MaCo=N'" + txtMaco.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
                resetvalue();
            }
           
           
        }

        private void DataGridView_Co_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaco.Text = DataGridView_Co.CurrentRow.Cells["Maco"].Value.ToString();
            txtTenco.Text = DataGridView_Co.CurrentRow.Cells["Tenco"].Value.ToString();
            txtMaco.Enabled = false;
        }
    }
}
