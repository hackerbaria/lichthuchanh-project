namespace Presentation_Layer
{
    partial class FormGiaoVien
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
            this.DGVGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVGiaoVien
            // 
            this.DGVGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.DiaChi,
            this.SoDienThoai});
            this.DGVGiaoVien.Location = new System.Drawing.Point(3, 47);
            this.DGVGiaoVien.Name = "DGVGiaoVien";
            this.DGVGiaoVien.Size = new System.Drawing.Size(445, 229);
            this.DGVGiaoVien.TabIndex = 0;
            this.DGVGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaGV
            // 
            this.MaGV.HeaderText = "Ma Giáo Viên";
            this.MaGV.Name = "MaGV";
            // 
            // TenGV
            // 
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // FormGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 288);
            this.Controls.Add(this.DGVGiaoVien);
            this.Name = "FormGiaoVien";
            this.Text = "FormGiaoVien";
            this.Load += new System.EventHandler(this.FormGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}