using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Drawing;
using System.Collections;

namespace DoAnTinHoc
{
    public class CGiaiThuat
    {
        private static int buoc;
        public static void hienMang(int[] mang, ListBox listBox, string chuoi)
        {
            listBox.Items.Add(chuoi + string.Join(" ", mang) + " - Thời gian:" + demtg.Elapsed.Seconds + " s");
        }
        public static void moPhong(int[] mang, TextBox[] txtArray, Label[] lblArray, int indexI, int indexJ)
        {
            for (int i = 0; i < txtArray.Length; i++)
            {
                if (i == indexI)
                {
                    txtArray[i].BackColor = Color.Aqua;
                    lblArray[i].Text = "↑";
                }
                else if(i == indexJ)
                {
                    txtArray[i].BackColor = Color.Brown;
                    lblArray[i].Text = "↑";
                }
                else
                {
                    txtArray[i].BackColor = Color.White;
                    lblArray[i].Text = "[" + i + "]";
                }
            }
        }
        public static Stopwatch demtg = new Stopwatch();
        public static async void BubbleSort(int[] mang,ListBox listbox, TextBox[] txtArray, Label[] lblArray)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[i] > mang[j])
                    {
                        int temp = mang[i];
                        mang[i] = mang[j];
                        mang[j] = temp;
                        moPhong(mang, txtArray, lblArray, i, j);
                        hienMang(mang, listbox, $"Bước {buoc++}: Đổi {mang[j]} và {mang[i]} => ");
                        await Task.Delay(3000);
                        txtArray[i].Text = mang[i].ToString();
                        txtArray[j].Text = mang[j].ToString();
                    }
                }
            }
            demtg.Stop();
        }
        public static async void BubbleSortDescending(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[i] < mang[j])
                    {
                        int temp = mang[i];
                        mang[i] = mang[j];
                        mang[j] = temp;
                        moPhong(mang, txtArray, lblArray, i, j);
                        hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[j]} và {mang[i]} => ");
                        await Task.Delay(3000);
                        txtArray[i].Text = mang[i].ToString();
                        txtArray[j].Text = mang[j].ToString();
                    }
                }
            }
            demtg.Stop();
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
                //hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[i]} và {mang[minIndex]} => ");
            }
            demtg.Stop();
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
                //hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[i]} và {mang[maxIndex]} => ");
            }
            demtg.Stop();
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
                    //hienMang(mang, listBox, $"Bước {buoc++}: Di chuyển {mang[j + 1]} đến vị trí {j + 2} => ");
                }
                mang[j + 1] = key;
                //hienMang(mang, listBox, $"Bước {buoc++}: Chèn {key} vào vị trí {j + 1} => ");
            }
            demtg.Stop();
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
                    //hienMang(mang, listBox, $"Bước {buoc++}: Di chuyển {mang[j + 1]} đến vị trí {j + 2} => ");
                }
                mang[j + 1] = key;
                //hienMang(mang, listBox, $"Bước {buoc++}: Chèn {key} vào vị trí {j + 1} => ");
            }
            demtg.Stop();
        }
    }
}
