using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap1
{
    class SinhVien
    {
        private string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string loai;
        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public float DiemTB { get => diemTB; 
            set {
                if (!KiemTraDiemTB(this.diemTB))
                { 
                    return; 
                }
                else
                {
                    diemTB = value;
                }

            }
        }
        public int NamSinh
        {
            get => namSinh;
            set
            {
                if (!KiemTraNamSinh(this.namSinh)) { return; }
                else
                {
                    namSinh = value;
                }
            }
        }

        public SinhVien()
        {
            this.maSo = "";
            this.hoTen = "";
            this.chuyenNganh = "";
            this.namSinh = 0;
            this.diemTB = 0;
           
        }

        public SinhVien(string maSo, string hoTen, string chuyenNganh, int namSinh, float diemTB)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
            XepLoai();
           
        }
        public SinhVien(SinhVien sv)
        {
            this.maSo = sv.maSo;
            this.hoTen = sv.hoTen;
            this.chuyenNganh = sv.chuyenNganh;
            this.namSinh = sv.namSinh;
            this.diemTB = sv.diemTB;
            XepLoai();
            

        }

       
        

        public bool KiemTraNamSinh(int ns)
        {
            int tuoi = DateTime.Now.Year - ns;
            if (tuoi>70|| tuoi <17 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool KiemTraDiemTB(float dtb)
        {
            if(dtb<0|| dtb>10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Ma So sinh vien: ");
            maSo = Console.ReadLine();
            Console.WriteLine("Nhap Ho Ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap Chuyen Nganh sinh vien: ");
            chuyenNganh = Console.ReadLine();
            do
            {
                Console.WriteLine("Nhap Nam Sinh sinh vien: ");
                namSinh = Int32.Parse(Console.ReadLine());
            }
            while (!KiemTraNamSinh(this.namSinh));
            
            do {
                Console.WriteLine("Nhap Diem Trung Binh sinh vien: ");
                diemTB = float.Parse(Console.ReadLine());
            }
            while (!KiemTraDiemTB(this.diemTB));
            XepLoai();


        }
        public void Xuat()
        {
            Console.WriteLine("Ma So: {0}\nHo Ten: {1}\nChuyen Nganh: {2}\nNam Sinh: {3}\nDiem Trung Binh: {4}\nXep Loai: {5}",this.maSo,this.hoTen,this.chuyenNganh,this.namSinh,this.diemTB,this.loai);
        }
        public void XepLoai()
        {
            if (diemTB<5)
            {
                this.loai = "Kem";
            }
            else if (diemTB < 7)
            {
                this.loai = "Trung Binh";
            }
            else if (diemTB < 8)
            {
                this.loai = "Kha";
            }
            else 
            {
                this.loai="Gioi";
            }
            
        }
    }
}
