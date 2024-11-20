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
            listBox.Items.Add(chuoi + string.Join(" ", mang) + " - Thời gian:" + demtg.Elapsed.Minutes + " phút " + demtg.Elapsed.Seconds + " giây");
        }
        public static void moPhong(int[] mang, TextBox[] txtArray, Label[] lblArray, int indexI, int indexJ)
        {
            for (int i = 0; i < txtArray.Length; i++)
            {
                if (i == indexI)
                {
                    txtArray[i].BackColor = Color.Aqua;
                    lblArray[i].Text = "i" + " = [" +i+ "]";
                }
                else if(i == indexJ)
                {
                    txtArray[i].BackColor = Color.Brown;
                    lblArray[i].Text = "j"+ " = [" + i + "]";
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
        public static async void SelectionSort(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray)
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
                moPhong(mang, txtArray, lblArray, i,minIndex);
                hienMang(mang, listBox, $"Bước {buoc++}:  Đổi {mang[i]} và {mang[minIndex]} => ");
                await Task.Delay(3000);
                txtArray[i].Text = mang[i].ToString();
                txtArray[minIndex].Text = mang[minIndex].ToString();
            }
            demtg.Stop();
        }
        public static async void SelectionSortDescending(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray)
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
                moPhong(mang, txtArray, lblArray, i, maxIndex);
                hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[i]} và {mang[maxIndex]} => ");
                await Task.Delay(3000);
                txtArray[i].Text = mang[i].ToString();
                txtArray[maxIndex].Text = mang[maxIndex].ToString();
            }
            demtg.Stop();
        }
        public static async void InsertionSort(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray)
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
                }
                mang[j + 1] = key;
                moPhong(mang, txtArray, lblArray, j + 1, i);
                hienMang(mang, listBox, $"Bước {buoc++}: Chèn {key} vào vị trí {j + 1} => ");
                await Task.Delay(3000);
                for (int k = 0; k < mang.Length; k++)
                {
                    txtArray[k].Text = mang[k].ToString();
                }
            }
            demtg.Stop();
        }
        public static async void InsertionSortDescending(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray)
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
                }
                mang[j + 1] = key;
                moPhong(mang, txtArray, lblArray, j + 1, i);
                hienMang(mang, listBox, $"Bước {buoc++}: Chèn {key} vào vị trí {j + 1} => ");
                await Task.Delay(3000);
                for (int k = 0; k < mang.Length; k++)
                {
                    txtArray[k].Text = mang[k].ToString();
                }
            }
            demtg.Stop();
        }
    }
}
