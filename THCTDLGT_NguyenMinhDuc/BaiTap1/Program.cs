using System;

namespace BaiTap1
{
    class Program
    {
        static void TestSinhVien()
        {
            SinhVien svA = new SinhVien();
            svA.Nhap();
            Console.WriteLine("Thong tin svA: ");
            svA.Xuat();
            SinhVien svB = new SinhVien("18DH001", "Lam Thanh Ngoc", "CNPM", 2000, 7.6F);
            Console.WriteLine("Thong tin svB: ");
            svB.Xuat();
            SinhVien svC = new SinhVien(svB);
            svC.Nhap();
            Console.WriteLine("Thong tin svC: ");
            svC.Xuat();
            svB.Xuat();

        }
        static void TestMangSinhVien()
        {
            MangSinhVien dssv = new MangSinhVien(3);
            dssv.Nhap();
            Console.WriteLine("Danh sach sinh vien:");
            dssv.Xuat();
        }
        static void Main(string[] args)
        {

            TestSinhVien();
            //TestMangSinhVien();
        }
    }
}
