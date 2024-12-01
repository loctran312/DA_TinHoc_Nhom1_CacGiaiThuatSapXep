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
        public static void hiencode(ListBox listcode, string chuoi)
        {
            listcode.Items.Add(chuoi);
        }
        public static void moPhong(int[] mang, TextBox[] txtArray, Label[] lblArray, int indexI, int indexJ)
        {
            for (int i = 0; i < txtArray.Length; i++)
            {
                if (i == indexI)
                {
                    txtArray[i].BackColor = Color.Aqua;
                    lblArray[i].Text = "i" + " = [" + i + "]";
                }
                else if (i == indexJ)
                {
                    txtArray[i].BackColor = Color.Brown;
                    lblArray[i].Text = "j" + " = [" + i + "]";
                }
                else
                {
                    txtArray[i].BackColor = Color.White;
                    lblArray[i].Text = "[" + i + "]";
                }
            }
        }
        public static Stopwatch demtg = new Stopwatch();
        public static async void BubbleSort(int[] mang, ListBox listbox, TextBox[] txtArray, Label[] lblArray, ListBox listcode, bool tangdan)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            await Task.Delay(1000);
            for (int i = 0; i < mang.Length; i++)
            {
                while (SapXep.pause == true)
                {
                    await Task.Delay(100);
                }
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (tangdan)
                    {
                        if (mang[i] > mang[j])
                        {
                            hiencode(listcode, "for(int i=0; i< mang.lenghth; i++)");
                            hiencode(listcode, "{");
                            hiencode(listcode, "    for (int j = i + 1; j < mang.Length; j++)");
                            hiencode(listcode, "    {");
                            hiencode(listcode, "        if(" + mang[i] + " > " + mang[j] + ")");
                            hiencode(listcode, "        {");
                            int temp = mang[i];
                            hiencode(listcode, "            int temp = " + mang[i] + ";");
                            mang[i] = mang[j];
                            hiencode(listcode, "            " + temp + " = " + mang[i] + ";");
                            mang[j] = temp;
                            hiencode(listcode, "            " + mang[i] + " = " + temp + ";");
                            hiencode(listcode, "        }");
                            hiencode(listcode, "    }");
                            hiencode(listcode, "}");
                            moPhong(mang, txtArray, lblArray, i, j);
                            if (SapXep.clear == false)
                            {
                                hienMang(mang, listbox, $"Bước {buoc++}: Đổi {mang[j]} và {mang[i]} => ");
                            }
                            await Task.Delay(SapXep.delay);
                            txtArray[i].Text = mang[i].ToString();
                            txtArray[j].Text = mang[j].ToString();
                        }
                    }
                    else
                    {
                        if (mang[i] < mang[j])
                        {
                            hiencode(listcode, "for(int i=0; i< mang.lenghth; i++)");
                            hiencode(listcode, "{");
                            hiencode(listcode, "    for (int j = i + 1; j < mang.Length; j++)");
                            hiencode(listcode, "    {");
                            hiencode(listcode, "        if (" + mang[i] + " < " + mang[j] + ")");
                            hiencode(listcode, "        {");
                            int temp = mang[i];
                            hiencode(listcode, "            int temp = " + mang[i] + ";");
                            mang[i] = mang[j];
                            hiencode(listcode, "            " + temp + " = " + mang[i] + ";");
                            mang[j] = temp;
                            hiencode(listcode, "            " + mang[i] + " = " + temp + ";");
                            hiencode(listcode, "        }");
                            hiencode(listcode, "    }");
                            hiencode(listcode, "}");
                            moPhong(mang, txtArray, lblArray, i, j);
                            if (SapXep.clear == false)
                            {
                                hienMang(mang, listbox, $"Bước {buoc++}: Đổi {mang[j]} và {mang[i]} => ");
                            }
                            await Task.Delay(SapXep.delay);
                            txtArray[i].Text = mang[i].ToString();
                            txtArray[j].Text = mang[j].ToString();
                        }
                    }
                }
            }
            demtg.Stop();
            SapXep.running = false;
        }
        public static async void SelectionSort(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray,ListBox listcode, bool tangdan)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            await Task.Delay(1000);
            for (int i = 0; i < mang.Length - 1; i++)
            {
                if (tangdan)
                {
                    hiencode(listcode, "for(int i = 0; i < mang.Length - 1; i++)");
                    hiencode(listcode, "{");
                    hiencode(listcode, "    int minIndex = " + i + ";");
                    hiencode(listcode, "    for(int j = i + 1; j < mang.Length; j++)");
                    hiencode(listcode, "    {");
                    int minIndex = i;
                    for (int j = i + 1; j < mang.Length; j++)
                    {
                        hiencode(listcode, "        if(" + mang[j] + " < mang[minIndex])");
                        hiencode(listcode, "        {");
                        if (mang[j] < mang[minIndex])
                        {
                            minIndex = j;
                        }
                        hiencode(listcode, "            minIndex = " + j + ";");
                    }
                    hiencode(listcode, "        }");
                    hiencode(listcode, "    }");
                    hiencode(listcode, "    int temp = mang[minIndex];");
                    int temp = mang[minIndex];
                    hiencode(listcode, "    mang[minIndex] = " + mang[i] + ";");
                    mang[minIndex] = mang[i];
                    hiencode(listcode, "    " + mang[i] + " = temp");
                    mang[i] = temp;
                    hiencode(listcode, "    }");
                    hiencode(listcode, "}");
                    while (SapXep.pause == true)
                    {
                        await Task.Delay(100);
                    }
                    moPhong(mang, txtArray, lblArray, i, minIndex);
                    if (SapXep.clear == false)
                    {
                        hienMang(mang, listBox, $"Bước {buoc++}:  Đổi {mang[i]} và {mang[minIndex]} => ");
                    }
                    await Task.Delay(SapXep.delay);
                    txtArray[i].Text = mang[i].ToString();
                    txtArray[minIndex].Text = mang[minIndex].ToString();
                }
                else
                {
                    hiencode(listcode, "for(int i = 0; i < mang.Length - 1; i++)");
                    hiencode(listcode, "{");
                    hiencode(listcode, "    int maxIndex = " + i + ";");
                    hiencode(listcode, "    for(int j = i + 1; j < mang.Length; j++)");
                    hiencode(listcode, "    {");
                    int maxIndex = i;
                    for (int j = i + 1; j < mang.Length; j++)
                    {
                        hiencode(listcode, "        if(" + mang[j] + " > mang[minIndex])");
                        hiencode(listcode, "        {");
                        if (mang[j] > mang[maxIndex])
                        {
                            maxIndex = j;
                        }
                        hiencode(listcode, "            maxIndex = " + j + ";");
                    }
                    hiencode(listcode, "        }");
                    hiencode(listcode, "    }");
                    hiencode(listcode, "    int temp = mang[maxIndex];");
                    int temp = mang[maxIndex];
                    hiencode(listcode, "    mang[maxIndex] = " + mang[i] + ";");
                    mang[maxIndex] = mang[i];
                    hiencode(listcode, "    " + mang[i] + " = temp");
                    mang[i] = temp;
                    hiencode(listcode, "    }");
                    hiencode(listcode, "}");
                    while (SapXep.pause == true)
                    {
                        await Task.Delay(100);
                    }
                    moPhong(mang, txtArray, lblArray, i, maxIndex);
                    if (SapXep.clear == false)
                    {
                        hienMang(mang, listBox, $"Bước {buoc++}: Đổi {mang[i]} và {mang[maxIndex]} => ");
                    }
                    await Task.Delay(SapXep.delay);
                    txtArray[i].Text = mang[i].ToString();
                    txtArray[maxIndex].Text = mang[maxIndex].ToString();
                }
            }
            demtg.Stop();
            SapXep.running = false;
        }
        public static async void InsertionSort(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray,ListBox listcode, bool tangdan)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            await Task.Delay(1000);
            for (int i = 1; i < mang.Length; i++)
            {
                if (tangdan)
                {
                    hiencode(listcode, "for(int i = 1; i < mang.Length; i++)");
                    hiencode(listcode, "{");
                    hiencode(listcode, "    int key = " + mang[i] + ";");
                    hiencode(listcode, "    int j = " + (i - 1) + ";");
                    int key = mang[i];
                    int j = i - 1;
                    hiencode(listcode, "    while(j >= 0 && " + mang[j] + " > key");
                    hiencode(listcode, "    {");
                    while (j >= 0 && mang[j] > key)
                    {
                        hiencode(listcode, "        mang[j + 1] = " + mang[j] + ";");
                        hiencode(listcode, "        j--;");
                        mang[j + 1] = mang[j];
                        j--;
                    }
                    hiencode(listcode, "    }");
                    hiencode(listcode, "    mang[j + 1] = key;");
                    hiencode(listcode, "}");
                    mang[j + 1] = key;
                    while (SapXep.pause == true)
                    {
                        await Task.Delay(100);
                    }
                    moPhong(mang, txtArray, lblArray, j + 1, i);
                    if (SapXep.clear == false)
                    {
                        hienMang(mang, listBox, $"Bước {buoc++}: Chèn {key} vào vị trí {j + 1} => ");
                    }
                    await Task.Delay(SapXep.delay);
                    for (int k = 0; k < mang.Length; k++)
                    {
                        txtArray[k].Text = mang[k].ToString();
                    }
                }
                else
                {
                    hiencode(listcode, "for(int i = 1; i < mang.Length; i++)");
                    hiencode(listcode, "{");
                    hiencode(listcode, "    int key = " + mang[i] + ";");
                    hiencode(listcode, "    int j = " + (i - 1) + ";");
                    int key = mang[i];
                    int j = i - 1;
                    hiencode(listcode, "    while(j >= 0 && " + mang[j] + " < key");
                    hiencode(listcode, "    {");
                    while (j >= 0 && mang[j] < key)
                    {
                        hiencode(listcode, "        mang[j + 1] = " + mang[j] + ";");
                        hiencode(listcode, "        j--;");
                        mang[j + 1] = mang[j];
                        j--;
                    }
                    hiencode(listcode, "    }");
                    hiencode(listcode, "    mang[j + 1] = key;");
                    hiencode(listcode, "}");
                    mang[j + 1] = key;
                    while (SapXep.pause == true)
                    {
                        await Task.Delay(100);
                    }
                    moPhong(mang, txtArray, lblArray, j + 1, i);
                    if (SapXep.clear == false)
                    {
                        hienMang(mang, listBox, $"Bước {buoc++}: Chèn {key} vào vị trí {j + 1} => ");
                    }
                    await Task.Delay(SapXep.delay);
                    for (int k = 0; k < mang.Length; k++)
                    {
                        txtArray[k].Text = mang[k].ToString();
                    }
                }
            }
            demtg.Stop();
            SapXep.running = false;
        }
    }
}