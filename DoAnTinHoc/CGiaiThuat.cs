using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoAnTinHoc
{
    public class CGiaiThuat
    {
        private static int buoc;
        public static void hienMang(int[] mang, ListBox listBox, string chuoi)
        {
            listBox.Items.Add(chuoi + string.Join(" ", mang) + " - Thời gian:" + demtg.Elapsed.Milliseconds + " milisecond");
        }
        public static Stopwatch demtg = new Stopwatch();
        public static void BubbleSort(int[] mang, ListBox listBox)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 0; i < mang.Length - 1; i++)
            {
                for (int j = 0; j < mang.Length - i - 1; j++)
                {
                    if (mang[j] > mang[j + 1])
                    {
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                        demtg.Stop();
                        hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[j + 1]} và {mang[j]} => ");
                    }
                }
            }
        }
        public static void BubbleSortDescending(int[] mang, ListBox listBox)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 0; i < mang.Length - 1; i++)
            {
                for (int j = 0; j < mang.Length - i - 1; j++)
                {
                    if (mang[j] < mang[j + 1])
                    {
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                        demtg.Stop();
                        hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[j + 1]} và {mang[j]} => ");
                    }
                }
            }
        }
        public static void SelectionSort(int[] mang, ListBox listBox)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 0; i < mang.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < mang.Length; j++) 
                {
                    if (mang[j] < mang[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = mang[minIndex];
                mang[minIndex] = mang[i];
                mang[i] = temp;
                demtg.Stop();
                hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[i]} và {mang[minIndex]} => ");
            }
        }
        public static void SelectionSortDescending(int[] mang, ListBox listBox)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 0; i < mang.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[j] > mang[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = mang[maxIndex];
                mang[maxIndex] = mang[i];
                mang[i] = temp;
                demtg.Stop();
                hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[i]} và {mang[maxIndex]} => ");
            }
        }
        public static void InsertionSort(int[] mang, ListBox listBox)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 1; i < mang.Length; i++)
            {
                int key = mang[i];
                int j = i - 1;
                while (j >= 0 && mang[j] > key)
                {
                    mang[j + 1] = mang[j];
                    j--;
                    hienMang(mang, listBox, $"Bước {buoc++}: Di chuyển {mang[j + 1]} đến vị trí {j + 2} => ");
                }
                mang[j + 1] = key;
                demtg.Stop();
                hienMang(mang, listBox, $"Bước {buoc++}: Chèn {key} vào vị trí {j + 1} => ");
            }
        }
        public static void InsertionSortDescending(int[] mang, ListBox listBox)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 1; i < mang.Length; i++)
            {
                int key = mang[i];
                int j = i - 1;
                while (j >= 0 && mang[j] < key)
                {
                    mang[j + 1] = mang[j];
                    j--;
                    hienMang(mang, listBox, $"Bước {buoc++}: Di chuyển {mang[j + 1]} đến vị trí {j + 2} => ");
                }
                mang[j + 1] = key;
                demtg.Stop();
                hienMang(mang, listBox, $"Bước {buoc++}: Chèn {key} vào vị trí {j + 1} => ");
            }
        }
        public static void CountingSort(int[] mang, ListBox listBox)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            int[] hamSort = new int[mang.Length];
            hienMang(hamSort, listBox, $"Bước {buoc++}: Khởi tạo mảng với {mang.Length} phần tử => ");

            int max = mang.Max();

            int[] hamDem = new int[max + 1];
            for (int i = 0; i < mang.Length; i++)
                hamDem[mang[i]]++;
            hienMang(hamDem, listBox, $"Bước {buoc++}: Đếm các số từ 0 đến {max} trong mảng : ");
            for (int i = 1; i <= max; i++)
                hamDem[i] += hamDem[i - 1];
            hienMang(hamDem, listBox, $"Bước {buoc++}: Tổng tích lũy của từng phần tử trong hàm đếm : ");
            
            int[] rong = new int[0];
            for (int i = mang.Length - 1; i >= 0; i--)
            {
                hienMang(hamDem, listBox, $"Bước {buoc++} : Hàm tổng tích lũy : ");
                hienMang(rong, listBox, $"Lấy số thứ {i + 1} của Dãy số ban đầu là {mang[i]} mà ô thứ {mang[i]}+1 của Hàm tổng tích lũy là {hamDem[mang[i]]}");
                hamSort[hamDem[mang[i]] - 1] = mang[i];
                hamDem[mang[i]]--;

                hienMang(hamSort, listBox, $"=> Cho {mang[i]} vào ô thứ {hamDem[mang[i]] + 1} của hàm đã duyệt=>");

            }
            for (int i = 0; i < mang.Length; i++)
            {
                mang[i] = hamSort[i];
            }
            demtg.Stop();
            hienMang(mang, listBox, "Mảng đã sắp xếp: ");
        }
        public static void CountingSortDescending(int[] mang, ListBox listBox)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            int[] hamSort = new int[mang.Length];
            hienMang(hamSort, listBox, $"Bước {buoc++}: Khởi tạo mảng với {mang.Length} phần tử => ");

            int max = mang.Max();

            int[] hamDem = new int[max + 1];
            for (int i = 0; i < mang.Length; i++)
                hamDem[mang[i]]++;
            hienMang(hamDem, listBox, $"Bước {buoc++}: Đếm các số từ 0 đến {max} trong mảng : ");
            for (int i = max - 1; i >= 0; i--) 
                hamDem[i] += hamDem[i + 1];
            hienMang(hamDem, listBox, $"Bước {buoc++}: Tổng tích lũy của từng phần tử trong hàm đếm : ");

            int[] rong = new int[0];
            for (int i = 0; i < mang.Length; i++) 
            {
                hienMang(hamDem, listBox, $"Bước {buoc++} : Hàm tổng tích lũy : ");
                hienMang(rong, listBox, $"Lấy số thứ {i + 1} của Dãy số ban đầu là {mang[i]} mà ô thứ {mang[i]}+1 của Hàm tổng tích lũy là {hamDem[mang[i]]}");
                hamSort[hamDem[mang[i]] - 1] = mang[i];
                hamDem[mang[i]]--;

                hienMang(hamSort, listBox, $"=> Cho {mang[i]} vào ô thứ {hamDem[mang[i]] + 1} của hàm đã duyệt=>");

            }
            for (int i = 0; i < mang.Length; i++)
            {
                mang[i] = hamSort[i];
            }
            demtg.Stop();
            hienMang(mang, listBox, "Mảng đã sắp xếp: ");
        }
    }
}
