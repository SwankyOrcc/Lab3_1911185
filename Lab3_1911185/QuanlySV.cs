using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab3_1911185
{
	public delegate int Sosanh(object sv1, object sv2);
	public class QuanlySV
	{
		public List<SinhVien> Danhsach;
		public QuanlySV()
		{
			Danhsach = new List<SinhVien>();
		}

		public void Them(SinhVien sv)
		{
			this.Danhsach.Add(sv);
		}

		public SinhVien this[int index]
		{
			get { return Danhsach[index]; }
			set { Danhsach[index] = value; }
		}

		public void Xoa(object obj,Sosanh ss)
		{
			int i = Danhsach.Count - 1;
			for (; i >= 0; i--)
				if (ss(obj, this[i]) == 0)
					this.Danhsach.RemoveAt(i);
		}

		public SinhVien Tim(object obj,Sosanh ss)
		{
			SinhVien svresult = null;
			foreach(SinhVien sv in Danhsach)
				if(ss(obj,sv)==0)
				{
					svresult = sv;
					break;
				}
			return svresult;
		}

		public bool Sua(SinhVien svsua,object obj,Sosanh ss)
		{
			int i, count;
			bool kq = false;
			count = this.Danhsach.Count - 1;
			for(i=0;i<count;i++)
				if(ss(obj,this[i])==0)
				{
					this[i] = svsua;
					kq = true;
					break;
				}
			return kq;
		}

		public void DocTuFile()
		{
			string filename = "DanhSachSV.txt", t;
			string[] s;
			SinhVien sv;
			StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
			while((t=sr.ReadLine())!=null)
			{
				s = t.Split(',');
				sv = new SinhVien();
				sv.Maso = s[0];
				sv.Hoten = s[1];
				sv.NgaySinh = DateTime.Parse(s[2]);
				sv.DiaChi = s[3];
				sv.Lop = s[4];
				sv.Hinh = s[5];
				sv.GioiTinh = false;
				if (s[6] == "1")
					sv.GioiTinh = true;
				string[] cn = s[7].Split(';');
				foreach (string c in cn)
					sv.ChuyenNganh.Add(c);
				this.Them(sv);

			}
		}
		
	}
}
