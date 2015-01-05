namespace Presentation_Layer
{
    partial class UCLopHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SoLuongSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSoSV = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuaLopHoc = new System.Windows.Forms.Button();
            this.btnThemLopHoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaLopHoc = new System.Windows.Forms.Button();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVLopHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // SoLuongSV
            // 
            this.SoLuongSV.DataPropertyName = "SoLuongSV";
            this.SoLuongSV.HeaderText = "Số Lượng Sinh Viên";
            this.SoLuongSV.Name = "SoLuongSV";
            this.SoLuongSV.Width = 160;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHuy.Location = new System.Drawing.Point(749, 264);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 34);
            this.btnHuy.TabIndex = 57;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Maroon;
            this.btnLuu.Location = new System.Drawing.Point(749, 224);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 34);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSoSV
            // 
            this.txtSoSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSoSV.Enabled = false;
            this.txtSoSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSV.Location = new System.Drawing.Point(637, 92);
            this.txtSoSV.Name = "txtSoSV";
            this.txtSoSV.Size = new System.Drawing.Size(216, 26);
            this.txtSoSV.TabIndex = 53;
            // 
            // txtTenLop
            // 
            this.txtTenLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(179, 119);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(224, 26);
            this.txtTenLop.TabIndex = 54;
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(179, 88);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(224, 26);
            this.txtMaLop.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tên Lớp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Mã Lớp Học  :";
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Số Lượng Sinh Viên :";
            // 
            // btnSuaLopHoc
            // 
            this.btnSuaLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLopHoc.ForeColor = System.Drawing.Color.Blue;
            this.btnSuaLopHoc.Location = new System.Drawing.Point(749, 184);
            this.btnSuaLopHoc.Name = "btnSuaLopHoc";
            this.btnSuaLopHoc.Size = new System.Drawing.Size(84, 34);
            this.btnSuaLopHoc.TabIndex = 47;
            this.btnSuaLopHoc.Text = "Sửa";
            this.btnSuaLopHoc.UseVisualStyleBackColor = true;
            this.btnSuaLopHoc.Click += new System.EventHandler(this.btnSuaLopHoc_Click);
            // 
            // btnThemLopHoc
            // 
            this.btnThemLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLopHoc.ForeColor = System.Drawing.Color.Blue;
            this.btnThemLopHoc.Location = new System.Drawing.Point(649, 184);
            this.btnThemLopHoc.Name = "btnThemLopHoc";
            this.btnThemLopHoc.Size = new System.Drawing.Size(88, 34);
            this.btnThemLopHoc.TabIndex = 46;
            this.btnThemLopHoc.Text = "Thêm";
            this.btnThemLopHoc.UseVisualStyleBackColor = true;
            this.btnThemLopHoc.Click += new System.EventHandler(this.btnThemLopHoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(321, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Bảng Thông Tin Lớp Học";
            // 
            // btnXoaLopHoc
            // 
            this.btnXoaLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLopHoc.ForeColor = System.Drawing.Color.Red;
            this.btnXoaLopHoc.Location = new System.Drawing.Point(649, 224);
            this.btnXoaLopHoc.Name = "btnXoaLopHoc";
            this.btnXoaLopHoc.Size = new System.Drawing.Size(88, 34);
            this.btnXoaLopHoc.TabIndex = 48;
            this.btnXoaLopHoc.Text = "Xóa";
            this.btnXoaLopHoc.UseVisualStyleBackColor = true;
            this.btnXoaLopHoc.Click += new System.EventHandler(this.btnXoaLopHoc_Click);
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.Width = 220;
            // 
            // DGVLopHoc
            // 
            this.DGVLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.SoLuongSV});
            this.DGVLopHoc.Location = new System.Drawing.Point(81, 184);
            this.DGVLopHoc.Name = "DGVLopHoc";
            this.DGVLopHoc.Size = new System.Drawing.Size(544, 283);
            this.DGVLopHoc.TabIndex = 44;
            this.DGVLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLopHoc_CellClick);
            // 
            // UCLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoSV);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSuaLopHoc);
            this.Controls.Add(this.btnThemLopHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaLopHoc);
            this.Controls.Add(this.DGVLopHoc);
            this.Name = "UCLopHoc";
            this.Size = new System.Drawing.Size(896, 514);
            this.Load += new System.EventHandler(this.UCLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSoSV;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSuaLopHoc;
        private System.Windows.Forms.Button btnThemLopHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridView DGVLopHoc;
    }
}
