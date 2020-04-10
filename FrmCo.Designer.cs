namespace QLyBanHangQuanAo
{
    partial class FrmCo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaco = new System.Windows.Forms.TextBox();
            this.txtTenco = new System.Windows.Forms.TextBox();
            this.DataGridView_Co = new System.Windows.Forms.DataGridView();
            this.Maco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Co)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Cỡ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Cỡ";
            // 
            // txtMaco
            // 
            this.txtMaco.Location = new System.Drawing.Point(130, 76);
            this.txtMaco.Name = "txtMaco";
            this.txtMaco.Size = new System.Drawing.Size(151, 20);
            this.txtMaco.TabIndex = 2;
            // 
            // txtTenco
            // 
            this.txtTenco.Location = new System.Drawing.Point(130, 121);
            this.txtTenco.Name = "txtTenco";
            this.txtTenco.Size = new System.Drawing.Size(151, 20);
            this.txtTenco.TabIndex = 3;
            // 
            // DataGridView_Co
            // 
            this.DataGridView_Co.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Co.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maco,
            this.Tenco});
            this.DataGridView_Co.Location = new System.Drawing.Point(190, 237);
            this.DataGridView_Co.Name = "DataGridView_Co";
            this.DataGridView_Co.Size = new System.Drawing.Size(243, 125);
            this.DataGridView_Co.TabIndex = 4;
            this.DataGridView_Co.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Co_CellClick);
            this.DataGridView_Co.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Co_CellContentClick);
            // 
            // Maco
            // 
            this.Maco.DataPropertyName = "Maco";
            this.Maco.HeaderText = "Mã Cỡ";
            this.Maco.Name = "Maco";
            // 
            // Tenco
            // 
            this.Tenco.DataPropertyName = "Tenco";
            this.Tenco.HeaderText = "Tên Cỡ";
            this.Tenco.Name = "Tenco";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(491, 398);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(358, 398);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(190, 398);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 398);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(621, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.DataGridView_Co);
            this.Controls.Add(this.txtTenco);
            this.Controls.Add(this.txtMaco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCo";
            this.Text = "FrmCo";
            this.Load += new System.EventHandler(this.FrmCo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Co)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaco;
        private System.Windows.Forms.TextBox txtTenco;
        private System.Windows.Forms.DataGridView DataGridView_Co;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenco;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}