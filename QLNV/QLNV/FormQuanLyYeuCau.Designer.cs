namespace QLNV
{
    partial class FormQuanLyYeuCau
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
            this.TimYeuCaubutton = new System.Windows.Forms.Button();
            this.Suabutton = new System.Windows.Forms.Button();
            this.Xoabutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TaoCabutton = new System.Windows.Forms.Button();
            this.SoLuongCatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NgayChonCadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // TimYeuCaubutton
            // 
            this.TimYeuCaubutton.Location = new System.Drawing.Point(501, 291);
            this.TimYeuCaubutton.Name = "TimYeuCaubutton";
            this.TimYeuCaubutton.Size = new System.Drawing.Size(75, 23);
            this.TimYeuCaubutton.TabIndex = 1;
            this.TimYeuCaubutton.Text = "Tìm";
            this.TimYeuCaubutton.UseVisualStyleBackColor = true;
            // 
            // Suabutton
            // 
            this.Suabutton.Location = new System.Drawing.Point(605, 291);
            this.Suabutton.Name = "Suabutton";
            this.Suabutton.Size = new System.Drawing.Size(75, 23);
            this.Suabutton.TabIndex = 2;
            this.Suabutton.Text = "Sửa";
            this.Suabutton.UseVisualStyleBackColor = true;
            // 
            // Xoabutton
            // 
            this.Xoabutton.Location = new System.Drawing.Point(713, 290);
            this.Xoabutton.Name = "Xoabutton";
            this.Xoabutton.Size = new System.Drawing.Size(75, 23);
            this.Xoabutton.TabIndex = 3;
            this.Xoabutton.Text = "Xóa";
            this.Xoabutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 22);
            this.textBox1.TabIndex = 4;
            // 
            // TaoCabutton
            // 
            this.TaoCabutton.Location = new System.Drawing.Point(713, 349);
            this.TaoCabutton.Name = "TaoCabutton";
            this.TaoCabutton.Size = new System.Drawing.Size(75, 23);
            this.TaoCabutton.TabIndex = 5;
            this.TaoCabutton.Text = "Tạo Ca";
            this.TaoCabutton.UseVisualStyleBackColor = true;
            // 
            // SoLuongCatextBox
            // 
            this.SoLuongCatextBox.Location = new System.Drawing.Point(403, 349);
            this.SoLuongCatextBox.Name = "SoLuongCatextBox";
            this.SoLuongCatextBox.Size = new System.Drawing.Size(277, 22);
            this.SoLuongCatextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngày / Tháng /Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số Lượng Ca";
            // 
            // NgayChonCadateTimePicker1
            // 
            this.NgayChonCadateTimePicker1.Location = new System.Drawing.Point(12, 349);
            this.NgayChonCadateTimePicker1.Name = "NgayChonCadateTimePicker1";
            this.NgayChonCadateTimePicker1.Size = new System.Drawing.Size(385, 22);
            this.NgayChonCadateTimePicker1.TabIndex = 10;
            // 
            // FormQuanLyYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 461);
            this.Controls.Add(this.NgayChonCadateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoLuongCatextBox);
            this.Controls.Add(this.TaoCabutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Xoabutton);
            this.Controls.Add(this.Suabutton);
            this.Controls.Add(this.TimYeuCaubutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormQuanLyYeuCau";
            this.Text = "QuanLyYeuCau";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TimYeuCaubutton;
        private System.Windows.Forms.Button Suabutton;
        private System.Windows.Forms.Button Xoabutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TaoCabutton;
        private System.Windows.Forms.TextBox SoLuongCatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker NgayChonCadateTimePicker1;
    }
}