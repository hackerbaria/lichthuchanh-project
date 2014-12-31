namespace Presentation_Layer
{
    partial class FormAutoSchedule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.btnSinhMa = new System.Windows.Forms.Button();
            this.btnThemLichDay2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 376);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(512, 394);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(97, 23);
            this.btnLoadData.TabIndex = 25;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(431, 394);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(112, 396);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(302, 20);
            this.txtPath.TabIndex = 23;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(34, 344);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(1002, 20);
            this.txtTenGV.TabIndex = 27;
            // 
            // btnSinhMa
            // 
            this.btnSinhMa.Location = new System.Drawing.Point(682, 394);
            this.btnSinhMa.Name = "btnSinhMa";
            this.btnSinhMa.Size = new System.Drawing.Size(97, 23);
            this.btnSinhMa.TabIndex = 25;
            this.btnSinhMa.Text = "SinhMa";
            this.btnSinhMa.UseVisualStyleBackColor = true;
            this.btnSinhMa.Click += new System.EventHandler(this.btnSinhMa_Click);
            // 
            // btnThemLichDay2
            // 
            this.btnThemLichDay2.Location = new System.Drawing.Point(814, 394);
            this.btnThemLichDay2.Name = "btnThemLichDay2";
            this.btnThemLichDay2.Size = new System.Drawing.Size(125, 23);
            this.btnThemLichDay2.TabIndex = 25;
            this.btnThemLichDay2.Text = "Thêm Lịch Dạy 2";
            this.btnThemLichDay2.UseVisualStyleBackColor = true;
            this.btnThemLichDay2.Click += new System.EventHandler(this.btnSinhMa_Click);
            // 
            // FormAutoSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 434);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThemLichDay2);
            this.Controls.Add(this.btnSinhMa);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Name = "FormAutoSchedule";
            this.Text = "Tạo Lịch Thực Hành Tự Động";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Button btnSinhMa;
        private System.Windows.Forms.Button btnThemLichDay2;
    }
}