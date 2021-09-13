using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_1911185
{
	public class SinhVien
	{
		public string Maso { get; set; }
		public string Hoten { get; set; }
		public DateTime NgaySinh { get; set; }
		public string DiaChi { get; set; }
		public string Lop { get; set; }
		public string Hinh { get; set; }
		public bool GioiTinh { get; set; }
		public List<string> ChuyenNganh { get; set; }
		public SinhVien()
		{
			ChuyenNganh = new List<string>();
		}
		public SinhVien(string ms,string ht,DateTime ngay,string dc, string lop,string hinh,bool gt,List<string>cn)
		{
			this.Maso = ms;
			this.Hoten = ht;
			this.NgaySinh = ngay;
			this.DiaChi = dc;
			this.Lop = lop;
			this.Hinh = hinh;
			this.GioiTinh = gt;
			this.ChuyenNganh = cn;
		}
	}
}
