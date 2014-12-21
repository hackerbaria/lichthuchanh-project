namespace Presentation_Layer
{
    partial class FormXemLichGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTuan1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuan1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTuan1
            // 
            this.dgvTuan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuan1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buoi,
            this.Phong,
            this.Thu2,
            this.Thu3,
            this.Thu4,
            this.Thu5,
            this.Thu6,
            this.Thu7,
            this.CN});
            this.dgvTuan1.Location = new System.Drawing.Point(30, 110);
            this.dgvTuan1.Name = "dgvTuan1";
            this.dgvTuan1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTuan1.Size = new System.Drawing.Size(1051, 567);
            this.dgvTuan1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Xem Lịch Dạy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Giáo Viên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Giáo Viên :";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Location = new System.Drawing.Point(509, 39);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(178, 26);
            this.txtMaGV.TabIndex = 15;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.Location = new System.Drawing.Point(509, 74);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(178, 26);
            this.txtTenGV.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(800, 61);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 39);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "In Lịch";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // Buoi
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buoi.DefaultCellStyle = dataGridViewCellStyle1;
            this.Buoi.HeaderText = "Buổi";
            this.Buoi.MinimumWidth = 10;
            this.Buoi.Name = "Buoi";
            this.Buoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phong
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phong.DefaultCellStyle = dataGridViewCellStyle2;
            this.Phong.HeaderText = "Phòng";
            this.Phong.Name = "Phong";
            this.Phong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Thu2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Thu2.HeaderText = "Thứ 2";
            this.Thu2.Name = "Thu2";
            this.Thu2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Thu2.Width = 110;
            // 
            // Thu3
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Thu3.HeaderText = "Thứ 3";
            this.Thu3.Name = "Thu3";
            this.Thu3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Thu3.Width = 110;
            // 
            // Thu4
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Thu4.HeaderText = "Thứ 4";
            this.Thu4.Name = "Thu4";
            this.Thu4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Thu4.Width = 110;
            // 
            // Thu5
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Thu5.HeaderText = "Thứ 5";
            this.Thu5.Name = "Thu5";
            this.Thu5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Thu5.Width = 110;
            // 
            // Thu6
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Thu6.HeaderText = "Thứ 6";
            this.Thu6.Name = "Thu6";
            this.Thu6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Thu6.Width = 110;
            // 
            // Thu7
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu7.DefaultCellStyle = dataGridViewCellStyle8;
            this.Thu7.HeaderText = "Thứ 7";
            this.Thu7.Name = "Thu7";
            this.Thu7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Thu7.Width = 110;
            // 
            // CN
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CN.DefaultCellStyle = dataGridViewCellStyle9;
            this.CN.HeaderText = "Chủ Nhật";
            this.CN.Name = "CN";
            this.CN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormXemLichGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 689);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTuan1);
            this.Name = "FormXemLichGiaoVien";
            this.Text = "FormXemLichGiaoVien";
            this.Load += new System.EventHandler(this.FormXemLichGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuan1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTuan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN;
    }
}