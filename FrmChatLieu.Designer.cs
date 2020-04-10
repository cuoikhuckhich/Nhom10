namespace QLyBanHangQuanAo
{
    partial class FrmChatLieu
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
            this.txtMachatlieu = new System.Windows.Forms.TextBox();
            this.txtTenchatlieu = new System.Windows.Forms.TextBox();
            this.DataGridView_ChatLieu = new System.Windows.Forms.DataGridView();
            this.Machatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenchatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chất Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Chất Liệu";
            // 
            // txtMachatlieu
            // 
            this.txtMachatlieu.Location = new System.Drawing.Point(162, 81);
            this.txtMachatlieu.Name = "txtMachatlieu";
            this.txtMachatlieu.Size = new System.Drawing.Size(193, 20);
            this.txtMachatlieu.TabIndex = 2;
            // 
            // txtTenchatlieu
            // 
            this.txtTenchatlieu.Location = new System.Drawing.Point(162, 160);
            this.txtTenchatlieu.Name = "txtTenchatlieu";
            this.txtTenchatlieu.Size = new System.Drawing.Size(193, 20);
            this.txtTenchatlieu.TabIndex = 3;
            // 
            // DataGridView_ChatLieu
            // 
            this.DataGridView_ChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ChatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Machatlieu,
            this.Tenchatlieu});
            this.DataGridView_ChatLieu.Location = new System.Drawing.Point(162, 245);
            this.DataGridView_ChatLieu.Name = "DataGridView_ChatLieu";
            this.DataGridView_ChatLieu.Size = new System.Drawing.Size(246, 114);
            this.DataGridView_ChatLieu.TabIndex = 4;
            this.DataGridView_ChatLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ChatLieu_CellClick);
            this.DataGridView_ChatLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ChatLieu_CellContentClick);
            // 
            // Machatlieu
            // 
            this.Machatlieu.DataPropertyName = "Machatlieu";
            this.Machatlieu.HeaderText = "Mã Chất Liệu";
            this.Machatlieu.Name = "Machatlieu";
            // 
            // Tenchatlieu
            // 
            this.Tenchatlieu.DataPropertyName = "Tenchatlieu";
            this.Tenchatlieu.HeaderText = "Tên Chất Liệu";
            this.Tenchatlieu.Name = "Tenchatlieu";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(60, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 28);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(204, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 28);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(479, 388);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(65, 28);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(640, 388);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(65, 28);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(353, 388);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 28);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FrmChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataGridView_ChatLieu);
            this.Controls.Add(this.txtTenchatlieu);
            this.Controls.Add(this.txtMachatlieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmChatLieu";
            this.Text = "FrmChatLieu";
            this.Load += new System.EventHandler(this.FrmChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMachatlieu;
        private System.Windows.Forms.TextBox txtTenchatlieu;
        private System.Windows.Forms.DataGridView DataGridView_ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenchatlieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
    }
}