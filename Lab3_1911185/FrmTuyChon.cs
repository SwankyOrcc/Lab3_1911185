using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3_1911185
{
	public partial class FrmTuyChon : Form
	{
		public int check;
		public string kq;
		public FrmTuyChon(int check=0)
		{
			this.check = check;
			InitializeComponent();
		}

		public void Chon()
		{

			
		}

		private void btnSapXep_Click(object sender, EventArgs e)
		{
			if(rdbMaSV.Checked)
			{
				kq = "Mã số";

			}
			else if(rdbHoTen.Checked)
			{
				kq = "Họ tên";
			}
			else if(rdbNgaySinh.Checked)
			{
				kq = "Ngày sinh";
			}
			this.Close();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			if (rdbMaSV.Checked)
			{
				kq = "Mã số" + ";"+txtNhapThongTin.Text;

			}
			else if (rdbHoTen.Checked)
			{
				kq = "Họ tên" +";" +txtNhapThongTin.Text;
			}
			else if (rdbNgaySinh.Checked)
			{
				kq = "Ngày sinh" +";"+ txtNhapThongTin.Text;
			}
			this.Close();
		}

		private void FrmTuyChon_Load(object sender, EventArgs e)
		{
			if(check==0)
			{
				grbTimKiem.Enabled = false;
			}	
			else
			{
				grbTimKiem.Enabled = true;
				btnSapXep.Enabled = false;
			}
		}
	}
}
