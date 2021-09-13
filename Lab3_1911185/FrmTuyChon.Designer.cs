
namespace Lab3_1911185
{
	partial class FrmTuyChon
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
			this.txtNhapThongTin = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.rdbMaSV = new System.Windows.Forms.RadioButton();
			this.rdbHoTen = new System.Windows.Forms.RadioButton();
			this.rdbNgaySinh = new System.Windows.Forms.RadioButton();
			this.btnSapXep = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.grbTimKiem = new System.Windows.Forms.GroupBox();
			this.grbTimKiem.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập thông tin";
			// 
			// txtNhapThongTin
			// 
			this.txtNhapThongTin.Location = new System.Drawing.Point(117, 15);
			this.txtNhapThongTin.Name = "txtNhapThongTin";
			this.txtNhapThongTin.Size = new System.Drawing.Size(177, 23);
			this.txtNhapThongTin.TabIndex = 1;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(305, 15);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(52, 23);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Tìm";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// rdbMaSV
			// 
			this.rdbMaSV.AutoSize = true;
			this.rdbMaSV.Location = new System.Drawing.Point(47, 27);
			this.rdbMaSV.Name = "rdbMaSV";
			this.rdbMaSV.Size = new System.Drawing.Size(58, 19);
			this.rdbMaSV.TabIndex = 3;
			this.rdbMaSV.TabStop = true;
			this.rdbMaSV.Text = "Mã SV";
			this.rdbMaSV.UseVisualStyleBackColor = true;
			// 
			// rdbHoTen
			// 
			this.rdbHoTen.AutoSize = true;
			this.rdbHoTen.Location = new System.Drawing.Point(141, 27);
			this.rdbHoTen.Name = "rdbHoTen";
			this.rdbHoTen.Size = new System.Drawing.Size(61, 19);
			this.rdbHoTen.TabIndex = 4;
			this.rdbHoTen.TabStop = true;
			this.rdbHoTen.Text = "Họ tên";
			this.rdbHoTen.UseVisualStyleBackColor = true;
			// 
			// rdbNgaySinh
			// 
			this.rdbNgaySinh.AutoSize = true;
			this.rdbNgaySinh.Location = new System.Drawing.Point(240, 27);
			this.rdbNgaySinh.Name = "rdbNgaySinh";
			this.rdbNgaySinh.Size = new System.Drawing.Size(78, 19);
			this.rdbNgaySinh.TabIndex = 5;
			this.rdbNgaySinh.TabStop = true;
			this.rdbNgaySinh.Text = "Ngày sinh";
			this.rdbNgaySinh.UseVisualStyleBackColor = true;
			// 
			// btnSapXep
			// 
			this.btnSapXep.Location = new System.Drawing.Point(94, 151);
			this.btnSapXep.Name = "btnSapXep";
			this.btnSapXep.Size = new System.Drawing.Size(77, 36);
			this.btnSapXep.TabIndex = 6;
			this.btnSapXep.Text = "Sắp xếp";
			this.btnSapXep.UseVisualStyleBackColor = true;
			this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(226, 151);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(77, 36);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// grbTimKiem
			// 
			this.grbTimKiem.Controls.Add(this.label1);
			this.grbTimKiem.Controls.Add(this.txtNhapThongTin);
			this.grbTimKiem.Controls.Add(this.btnFind);
			this.grbTimKiem.Location = new System.Drawing.Point(31, 52);
			this.grbTimKiem.Name = "grbTimKiem";
			this.grbTimKiem.Size = new System.Drawing.Size(363, 56);
			this.grbTimKiem.TabIndex = 7;
			this.grbTimKiem.TabStop = false;
			// 
			// FrmTuyChon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 230);
			this.Controls.Add(this.grbTimKiem);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSapXep);
			this.Controls.Add(this.rdbNgaySinh);
			this.Controls.Add(this.rdbHoTen);
			this.Controls.Add(this.rdbMaSV);
			this.Name = "FrmTuyChon";
			this.Text = "Tuỳ chọn";
			this.Load += new System.EventHandler(this.FrmTuyChon_Load);
			this.grbTimKiem.ResumeLayout(false);
			this.grbTimKiem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNhapThongTin;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.RadioButton rdbMaSV;
		private System.Windows.Forms.RadioButton rdbHoTen;
		private System.Windows.Forms.RadioButton rdbNgaySinh;
		private System.Windows.Forms.Button btnSapXep;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox grbTimKiem;
	}
}