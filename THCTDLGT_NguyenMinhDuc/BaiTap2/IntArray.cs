using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2
{
    public class IntArray
    {
        private int[] arr;
        public int this[int index] { get => arr[index]; set => arr[index] = value; }
        public IntArray()
        {
            int[] arr = new int[0];
        }
        public IntArray(int k)
        {
            while (!KiemTraTK(k))
            {
                Console.WriteLine("Nhap lai so luong phan tu: ");
                k = Int32.Parse(Console.ReadLine());
            }
            arr = new int[k];
            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                arr[i] = random.Next(1, 200);
            }

        }
        public IntArray(int[] a)
        {
            arr = a;
        }
        public IntArray(IntArray obj)
        {
            this.arr = obj.arr;
        }


        public bool KiemTraTK(int n)
        {

            if (n > 0 && n < 1000000)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Nhap()
        {

            Console.WriteLine("Nhap so luong phan tu: ");
            int size = Int32.Parse(Console.ReadLine());
            while (!KiemTraTK(size))
            {
                Console.WriteLine("Nhap lai so luong phan tu: ");
                size = Int32.Parse(Console.ReadLine());
            }
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Phan tu {0}: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0}", arr[i]);
            }
            Console.WriteLine();
        }
        public int TimTuanTu(int x)
        {
            int sosanh = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("\nSo sanh {0} voi {1}", arr[i], x);
                sosanh++;
                if (arr[i] == x)
                {
                    Console.WriteLine("Do {0} = {1} nen tra ve vi tri", arr[i], x);
                    Console.WriteLine("Tong so lan so sanh: ", sosanh);
                    return i;
                }

            }
            Console.WriteLine("Tong so lan so sanh: ", sosanh);
            return -1;
        }
        public int TimNhiPhan(int x)
        {
            int left = 0;
            int right = arr.Length - 1;
            int sosanh = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                Console.WriteLine("\nLeft: {0} Mid: {1} Right: {2}", left, mid, right);
                Console.WriteLine("Left: [{0}] Mid:{1}  [{2}]", string.Join(" ", arr[left..(mid)]), mid, string.Join(", ", arr[(mid + 1)..right]));
                sosanh++;

                if (arr[mid] == x)
                {
                    Console.WriteLine("Tong so lan so sanh: {0}", sosanh);
                    return mid;
                }
                else if (arr[mid] < x)
                {
                    Console.WriteLine("Do {0} < {1} nen left = mid + 1", arr[mid], x);
                    left = mid + 1;
                }
                else
                {
                    Console.WriteLine("Do {0} > {1} nen right = mid - 1", arr[mid], x);
                    right = mid - 1;
                }
            }
            Console.WriteLine("Tong so lan so sanh: {0}", sosanh);
            return -1;
        }
        public int TimSoLonNhat()
        {
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public void ThemPhanTu(int x)
        {

            Array.Resize(ref arr, arr.Length + 1);
            int maxIndex = TimSoLonNhat();
            for (int i = arr.Length - 1; i > maxIndex + 1; i--)
            {
                int temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
            }
            arr[maxIndex + 1] = x;
            Xuat();

        }
        public void XoaPhanTu(int x)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == x)
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            if (arr[arr.Length - 1] == x)
            {
                Array.Resize(ref arr, arr.Length - 1);
                Xuat();
            }
        }
        public void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }
        public void InterchangeSort()
        {
            int phepGan = 2;
            int phepSoSanh = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
               
                
                for (int j = i + 1; j < n; j++)
                {
                    Console.WriteLine("Vi tri i: {0}   Vi tri j: {1}", i, j);
                    phepGan ++;
                    phepSoSanh++;
                    Console.WriteLine("So sanh giua arr[{0}] voi arr[{1}]", i, j);
                    if (arr[i] > arr[j])
                    {
                        Console.WriteLine("{0} > {1} cho nen hoan vi", arr[i], arr[j]);
                        phepSoSanh++;
                        HoanVi(ref arr[i], ref arr[j]);
                        phepGan += 3;
                        Console.WriteLine("Sau khi hoan vi arr[{0}] voi arr[{1}]", i, j);
                        Xuat();
                    }
                    else
                    {
                        Console.WriteLine("{0} < {1}", arr[i], arr[j]);
                    }
                    Console.WriteLine("Tang j");
                }
                phepSoSanh++;
                phepGan++;
                Console.WriteLine("Tang i");


            }
            Console.WriteLine("\nFinal So phep gan: {0}\nSo phep so sanh: {1}",phepGan,phepSoSanh);
        }
        public void BubbleSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        HoanVi(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }
        public void SelectionSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int vtmin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[vtmin])
                        vtmin = j;
                }
                HoanVi(ref arr[vtmin], ref arr[i]);
            }
        }
        public void InsertionSort()
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int x = arr[i];
                int pos = i - 1;
                while (pos >= 0 && arr[pos] > x)
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = x;
            }
        }
        public void QuickSort(int left, int right)
        {
            if(left < right)
            {
                int pivot = PhanHoach(left, right);
                QuickSort(left, pivot - 1);
                QuickSort(pivot + 1, right);
            }
        }

        public int PhanHoach(int left, int right)
        {
            int pivot = arr[right];

            int i = (left);
            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    HoanVi(ref arr[j], ref arr[i]);
                    i++;
                    
                }
            }
            HoanVi(ref arr[i], ref arr[right]);
            return i;
        }
        public void ShellSort()
        {
            int n = arr.Length;
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }
        public void ShakerSort()
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;

            while (swapped == true)
            {
                swapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        HoanVi(ref arr[i + 1], ref arr[i]);
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
                swapped = false;
                end = end - 1;
                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        HoanVi(ref arr[i+1], ref arr[i]);
                        swapped = true;
                    }
                }
                start = start + 1;
            }
        }
       
    }
}
