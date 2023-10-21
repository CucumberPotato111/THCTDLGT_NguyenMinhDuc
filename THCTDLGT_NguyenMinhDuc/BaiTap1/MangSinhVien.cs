using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap1
{
    class MangSinhVien
    {
        SinhVien[] a;

        internal SinhVien[] A { get => a; set => a = value; }

        public MangSinhVien()
        {
            a = new SinhVien[0];
        }
        public MangSinhVien(int n)
        {
            a = new SinhVien[n];
        }
        
        public bool TonTai(string msx, int vt)
        {
            for (int i = 0; i < vt; i++)
            {
                if (a[i].MaSo.CompareTo(msx) == 0)
                    return true;
            }
            return false;
        }
        public void Nhap()
        {
            int n;
            Console.Write("So luong sinh vien: ");
            int.TryParse(Console.ReadLine(), out n);
            a = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = new SinhVien();
                Console.WriteLine(">> Nhap thong tin sinh vien thu {0}:", i + 1);
                a[i].Nhap();
                //vi tri nhap = i --> tim 0-->i-1
                string mssv = a[i].MaSo;
                if (TonTai(mssv, i) == true)//ton tai mssv
                {
                    do
                    {
                        Console.WriteLine("--> Da ton tai sinh vien co ma so {0} trong danh sach", mssv);
                        Console.Write(">>> Hay nhap lai ma so sinh vien: ");
                        mssv = Console.ReadLine();
                    } while (TonTai(mssv, i));
                    a[i].MaSo = mssv;
                }
            }
        }
        public void Xuat()
        {
            
            foreach (SinhVien sv in a)
            {
                sv.Xuat();
            }
        }
        public void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }
        public void DanhSachTangDan()
        {

  
            
        }
        public void DanhSachGiamDan()
        {

        }
    }
    
}
