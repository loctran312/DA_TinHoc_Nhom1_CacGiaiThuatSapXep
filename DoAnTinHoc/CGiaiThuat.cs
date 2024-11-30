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
        public static void hiencode(ListBox lb,string chuoi) 
        {
            lb.Items.Add(chuoi);
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
        public static async void BubbleSort(int[] mang,ListBox listbox, TextBox[] txtArray, Label[] lblArray,ListBox lb,bool tangdan)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 0; i < mang.Length; i++)
            {
                while (SapXep.pause == true)
                { 
                    await Task.Delay(100);
                }
                hiencode(lb,"for(int i=0 ;i< mang.lenghth;i++)");
                hiencode(lb, "{");
                for (int j = i + 1; j < mang.Length; j++)
                {
                    hiencode(lb,"for (int j = i + 1; j < mang.Length; j++)");
                    hiencode(lb, "{");
                    if (tangdan)
                    {
                        if (mang[i] > mang[j])
                        { 
                            hiencode(lb, " if ("+mang[i]+" >"+ mang[j]+")");
                            hiencode(lb, "{");
                            int temp = mang[i];
                            hiencode(lb, "int temp = "+mang[i]+";");
                            mang[i] = mang[j];
                            hiencode(lb, temp+" ="+ mang[i]+";");
                            mang[j] = temp;
                            hiencode(lb,  mang[i]+" = "+temp+";");
                            hiencode(lb, "}");
                            hiencode(lb, "}");
                            hiencode(lb, "}");
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
                            hiencode(lb, " if (" + mang[i] + " <" + mang[j] + ")");
                            hiencode(lb, "{");
                            int temp = mang[i];
                            hiencode(lb, "int temp = " + mang[i] + ";");
                            mang[i] = mang[j];
                            hiencode(lb, temp + " =" + mang[i] + ";");
                            mang[j] = temp;
                            hiencode(lb, mang[i] + " = " + temp + ";");
                            hiencode(lb, "}");
                            hiencode(lb, "}");
                            hiencode(lb, "}");
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
        public static async void SelectionSort(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray,ListBox lb, bool tangdan)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 0; i < mang.Length - 1; i++)
            {
                while (SapXep.pause == true)
                {
                    await Task.Delay(100);
                }
                hiencode(lb, "for(int i=0 ;i< mang.length-1;i++)");
                hiencode(lb, "{");
                if (tangdan)
                {
                    int minIndex = i;
                    hiencode(lb, "int minIndex = " + i);
                    for (int j = i + 1; j < mang.Length; j++)
                    {
                        hiencode(lb, "for (int j = i + 1; j < mang.Length; j++)");
                        hiencode(lb, "{");
                        if (mang[j] < mang[minIndex])
                        {
                            hiencode(lb, "if(" + mang[j] + "<" + mang[minIndex]+")");
                            hiencode(lb, "{");
                            minIndex = j;
                            hiencode(lb, "minIndex = " + j);

                        }
                        hiencode(lb, "}");
                    }
                    hiencode(lb, "}");
                    int temp = mang[minIndex];
                    hiencode(lb, "int temp = " + mang[minIndex]);
                    mang[minIndex] = mang[i];
                    hiencode(lb, temp + "=" + mang[i]);
                    mang[i] = temp;
                    hiencode(lb, mang[i] + "= temp");
                    
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
                    int maxIndex = i;
                    hiencode(lb, "int maxIndex = " + i);
                    for (int j = i + 1; j < mang.Length; j++)
                    {
                        hiencode(lb, "for (int j = i + 1; j < mang.Length; j++)");
                        hiencode(lb, "{");
                        if (mang[j] > mang[maxIndex])
                        {
                            hiencode(lb, "if(" + mang[j] + "<" + mang[maxIndex] + ")");
                            hiencode(lb, "{");
                            maxIndex = j;
                            hiencode(lb, "maxIndex = " + j);

                        }
                        hiencode(lb, "}");
                    }
                    hiencode(lb, "}");
                    int temp = mang[maxIndex];
                    hiencode(lb, "int temp = " + mang[maxIndex]);
                    mang[maxIndex] = mang[i];
                    hiencode(lb, temp + "=" + mang[i]);
                    mang[i] = temp;
                    hiencode(lb, mang[i] + "= temp");
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
        public static async void InsertionSort(int[] mang, ListBox listBox, TextBox[] txtArray, Label[] lblArray,ListBox lb, bool tangdan)
        {
            buoc = 1;
            demtg.Reset();
            demtg.Start();
            for (int i = 1; i < mang.Length; i++)
            {
                hiencode(lb, "for (int i = 1; i < mang.Length; i++)");
                hiencode(lb, "{");
                while (SapXep.pause == true)
                {
                    await Task.Delay(100);
                }
                if (tangdan)
                {
                    int key = mang[i];
                    hiencode(lb, "int key = " + mang[i] + ";");
                    int j = i - 1;
                    hiencode(lb, "int j = "+(i - 1)+ ";");
                    while (j >= 0 && mang[j] > key)
                    {
                        hiencode(lb, "while ( "+j+"  >= 0 && " + mang[j] + " > key )");
                        hiencode(lb, "{");
                        mang[j + 1] = mang[j];
                        hiencode(lb, "mang[j + 1] =" + mang[j] + ";");
                        j--;
                        hiencode(lb, "j--");
                    }
                    hiencode(lb, "}");
                    mang[j + 1] = key;
                    hiencode(lb, " mang[j + 1] ="+key+";");
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
                    int key = mang[i];
                    hiencode(lb, "int key = " + mang[i] + ";");
                    int j = i - 1;
                    hiencode(lb, "int j = " + (i - 1) + ";");
                    while (j >= 0 && mang[j] < key)
                    {
                        hiencode(lb, "while ( "+j+"  >= 0 && " + mang[j] + " < key )");
                        hiencode(lb, "{");
                        mang[j + 1] = mang[j];
                        hiencode(lb, "mang[j + 1] =" + mang[j] + ";");
                        j--;
                        hiencode(lb, "j--");
                    }
                    hiencode(lb, "}");
                    mang[j + 1] = key;
                    hiencode(lb, " mang[j + 1] =" + key + ";");
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