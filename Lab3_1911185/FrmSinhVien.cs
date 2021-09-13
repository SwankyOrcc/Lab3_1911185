using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1911185
{
	public partial class Form1 : Form
	{
		QuanlySV qlsv;
		public Form1()
		{
			InitializeComponent();
		}

		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			bool gt = true;
			List<string> cn = new List<string>();
			sv.Maso = this.mtxtMaSo.Text;
			sv.Hoten = this.txtHoTen.Text;
			sv.NgaySinh = this.dtpNgaySinh.Value;
			sv.DiaChi = this.txtDiaChi.Text;
			sv.Lop = this.cboLop.Text;
			sv.Hinh = this.txtHinh.Text;
			if (rdNu.Checked)
				gt = false;
			sv.GioiTinh = gt;
			for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
				if (clbChuyenNganh.GetItemChecked(i))
					cn.Add(clbChuyenNganh.Items[i].ToString());
			sv.ChuyenNganh = cn;
			return sv;

		}

		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.Maso = lvitem.SubItems[0].Text;
			sv.Hoten = lvitem.SubItems[1].Text;
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
			sv.DiaChi = lvitem.SubItems[3].Text;
			sv.Lop = lvitem.SubItems[4].Text;
			sv.GioiTinh = false;
			if (lvitem.SubItems[5].Text == "Nam")
				sv.GioiTinh = true;
			List<string> cn = new List<string>();
			string[] s = lvitem.SubItems[6].Text.Split(',');
			foreach (string t in s)
				cn.Add(t);
			sv.ChuyenNganh = cn;
			sv.Hinh = lvitem.SubItems[7].Text;
			return sv;
		}

		private void ThietLapThongTin(SinhVien sv)
		{
			this.mtxtMaSo.Text = sv.Maso;
			this.txtHoTen.Text = sv.Hoten;
			this.dtpNgaySinh.Value = sv.NgaySinh;
			this.txtDiaChi.Text = sv.DiaChi;
			this.cboLop.Text = sv.Lop;
			this.txtHinh.Text = sv.Hinh;
			this.pbHinh.ImageLocation = sv.Hinh;
			if (sv.GioiTinh)
				this.rdNam.Checked = true;
			else
				this.rdNu.Checked = true;
			for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1; i++)
				this.clbChuyenNganh.SetItemChecked(i, false);
			foreach(string s in sv.ChuyenNganh)
			{
				for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
					if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
						this.clbChuyenNganh.SetItemChecked(i, true);
			}
		}

		private void ThemSV(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.Maso);
			lvitem.SubItems.Add(sv.Hoten);
			lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
			lvitem.SubItems.Add(sv.DiaChi);
			lvitem.SubItems.Add(sv.Lop);
			string gt = "Nữ";
			if (sv.GioiTinh)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			string cn = "";
			foreach (string s in sv.ChuyenNganh)
				cn += s + ",";
			cn = cn.Substring(0, cn.Length - 1);
			lvitem.SubItems.Add(cn);
			lvitem.SubItems.Add(sv.Hinh);
			this.lvSinhVien.Items.Add(lvitem);
		}

		private void LoadListView()
		{
			this.lvSinhVien.Items.Clear();
			foreach(SinhVien sv in qlsv.Danhsach)
			{
				ThemSV(sv);
			}
		}

		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = this.lvSinhVien.SelectedItems.Count;
			if(count>0)
			{
				ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
				SinhVien sv = GetSinhVienLV(lvitem);
				ThietLapThongTin(sv);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			 SinhVien kq = qlsv.Tim(sv.Maso, delegate (object obj1, object obj2)
                 {
				 return (obj2 as SinhVien).Maso.CompareTo(obj1.ToString());
				 });
			 if (kq != null)
				MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			 else
				 {
				 this.qlsv.Them(sv);
				 this.LoadListView();
				 }
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int count, i;
			ListViewItem lvitem;
			count = this.lvSinhVien.Items.Count - 1;
			for(i=count;i>=0;i--)
			{
				lvitem = this.lvSinhVien.Items[i];
				if (lvitem.Checked)
					qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
			}
			this.LoadListView();
			this.btnMacDinh.PerformClick();
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			this.mtxtMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.dtpNgaySinh.Value = DateTime.Now;
			this.txtDiaChi.Text = "";
			this.cboLop.Text = this.cboLop.Items[0].ToString();
			this.txtHinh.Text = "";
			this.pbHinh.ImageLocation = "";
			this.rdNam.Checked = true;
			for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1; i++)
				this.clbChuyenNganh.SetItemChecked(i, false);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			bool kqsua;
			kqsua = qlsv.Sua(sv, sv.Maso, SoSanhTheoMa);
			if(kqsua)
			{
				this.LoadListView();
			}
		}

		private int SoSanhTheoMa(object obj1,object obj2)
		{
			SinhVien sv = obj2 as SinhVien;
			return sv.Maso.CompareTo(obj1);
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			qlsv = new QuanlySV();
			qlsv.DocTuFile();
			LoadListView();
		}

		private void sắpXếpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FrmTuyChon frmTuychon = new FrmTuyChon(0);
			frmTuychon.ShowDialog();
			string kq = frmTuychon.kq;
			if(kq=="Mã số")
			{
				qlsv.Danhsach.Sort((x, y) => x.Maso.CompareTo(y.Maso));
				LoadListView();
			}
			else if(kq=="Họ tên")
			{
				qlsv.Danhsach.Sort((x, y) => x.Hoten.CompareTo(y.Hoten));
				LoadListView();
			}
			else if(kq=="Ngày sinh")
			{
				qlsv.Danhsach.Sort((x, y) => x.NgaySinh.CompareTo(y.NgaySinh));
				LoadListView();
			}
			
		}

		private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<SinhVien> dssv = new List<SinhVien>();
			SinhVien sv = new SinhVien();
			FrmTuyChon frmTuychon = new FrmTuyChon(1);
			frmTuychon.ShowDialog();
			if (frmTuychon.kq != null)
			{
				string[] kq = frmTuychon.kq.Split(';');
				if (kq[0] == "Mã số")
				{
					sv = qlsv.Danhsach.Find(x => x.Maso == kq[1]);
					if (sv != null)
					{
						this.lvSinhVien.Items.Clear();
						ThemSV(sv);
						DialogResult dialogRS =
						MessageBox.Show("Có 1 sv có mã số " + kq[1], "Kết quả tìm kiếm ");
						if (dialogRS == DialogResult.OK)
						{
							LoadListView();
						}
					}
					else
					{
						MessageBox.Show("Không có sv có mã số" + kq[1], "Lỗi tìm kiếm");
					}

				}
				else if (kq[0] == "Họ tên")
				{
					dssv = qlsv.Danhsach.FindAll(x => x.Hoten == kq[1]);
					if (dssv.Count > 0)
					{
						LoadListViewV2(dssv);
						DialogResult dialogRS =
						MessageBox.Show("Có  " + dssv.Count + " sv có họ tên " + kq[1], "Kết quả tìm kiếm ");
						if (dialogRS == DialogResult.OK)
						{
							LoadListView();
						}
					}
					else
					{
						MessageBox.Show("Không có sv có Họ tên" + kq[1], "Lỗi tìm kiếm");
					}
				}
				else if (kq[0] == "Ngày sinh")
				{
					dssv = qlsv.Danhsach.FindAll(x => x.NgaySinh == DateTime.Parse(kq[1]));
					if (dssv.Count >0)
					{
						LoadListViewV2(dssv);
						DialogResult dialogRS =
						MessageBox.Show("Có  " + dssv.Count + " sv có ngày sinh " + kq[1], "Kết quả tìm kiếm ");
						if (dialogRS == DialogResult.OK)
						{
							LoadListView();
						}
					}
					else
					{
						MessageBox.Show("Không có sv có Ngày sinh" + kq[1], "Lỗi tìm kiếm");
					}
				}
			}
			
		}

		private void LoadListViewV2(List<SinhVien> dssv)
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sv in dssv)
			{
				ThemSV(sv);
			}
		}
	}
}
