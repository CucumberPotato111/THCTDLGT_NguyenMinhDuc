using System;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestConstructor1();

            //TestConstructor2();
            //TestConstructor3();
            IntArray obj = new IntArray(10);
            TestInterchangeSort(obj);
            //TestBubbleSort(obj);
            //TestSelectionSort(obj);
            //TestInsertionSort(obj);
            //TestQuickSort(obj);
            //TestShellSort(obj);
            //TestShellSort(obj);

        }   
        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20);
            Console.WriteLine("Gia tri mang phat sinh: ");
            obj.Xuat();
            //Console.WriteLine("\nSo lon nhat tai vi tri: " + obj.TimSoLonNhat());
            //obj.ThemPhanTu(999);
        }
        static void TestConstructor2()
        {
            int[] a = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            IntArray obj = new IntArray(a);
            Console.WriteLine("Gia tri mang: ");
            obj.Xuat();
            Console.WriteLine("\nTai vi tri: "+obj.TimNhiPhan(6));
            obj.XoaPhanTu(6);
        }
        static void TestConstructor3()
        {
            IntArray obj1 = new IntArray();
            obj1.Nhap();
            Console.WriteLine("Gia tri mang: ");
            obj1.Xuat();
            IntArray obj2 = new IntArray(obj1);
            Console.WriteLine("\nGia tri mang copy: ");
            obj2.Xuat();
        }
        static void TestTimTuanTu()
        {
            int k, x, kq;
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();
            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);
            kq = obj.TimTuanTu(x);
            if (kq == -1)
                Console.WriteLine("->Khong ton tai {0}!", x);
            else
                Console.WriteLine("->Co {0} tai vi tri {1}", x, kq);
        }
        //Test phương pháp tìm nhị phân
        static void TestTimNhiPhan()
        {
            int k, x, kq;
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();
            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);
            kq = obj.TimTuanTu(x);
            if (kq == -1)
                Console.WriteLine("->Khong ton tai {0}!", x);
            else
                Console.WriteLine("->Co {0} tai vi tri {1}", x, kq);
        }
        static void TestInterchangeSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InterchangeSort();
            Console.WriteLine("\n>>Interchange Sort:");
            objTam.Xuat();
        }
        static void TestBubbleSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.BubbleSort();
            Console.WriteLine("\n>>Bubble Sort:");
            objTam.Xuat();
        }
        static void TestSelectionSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.SelectionSort();
            Console.WriteLine("\n>>Selection Sort:");
            objTam.Xuat();
        }
        static void TestInsertionSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InsertionSort();
            Console.WriteLine("\n>>Insertion Sort:");
            objTam.Xuat();
        }
        static void TestQuickSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.QuickSort(0,9);
            Console.WriteLine("\n>>Quick Sort:");
            objTam.Xuat();
        }
        static void TestShellSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.ShellSort();
            Console.WriteLine("\n>>Shell Sort:");
            objTam.Xuat();
        }
        static void TestShakerSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.ShellSort();
            Console.WriteLine("\n>>Shaker Sort:");
            objTam.Xuat();
        }
    }
}
