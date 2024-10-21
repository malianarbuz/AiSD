using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void printArray(int[] array)
        {
            String a = "[";
            for (int i = 0; i < array.Length; i++)
            {
                 a=a + array[i] + " , ";
            };
            MessageBox.Show(a+"]");
        }
        static int[] bubbleSort(int[] array)
        {
            bool change = true;
            int temp;
            int counter = 0;
            int n = array.Length;
            while (change)
            {
                change = false;
                for (int i = 1; i < n - counter; i++)
                {
                    if (array[i - 1] >= array[i])
                    {
                        temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        change = true;

                    }
                }
                counter++;
            }
            return array;
        }
        
        static int[] insertSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            return array;
        }
        static void mergeSort(int[] arr,int l,int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }       
        }
        private static void merge(int[] arr, int l, int m, int r)
        {
            int size1 = m - l + 1;
            int size2 = r - m;
            int[] L = new int[size1];
            int[] R = new int[size2];
            int i, j;
            for (i = 0; i < size1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < size2; ++j)
                R[j] = arr[m + 1 + j];
            i = 0;
            j = 0;

            int k = l;
            while (i < size1 && j < size2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < size1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < size2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        static int[] countingSort(int[] arr)
        {
            int max = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            
            
            return arr;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int[] arr=bubbleSort(new int[] { 3, 3, 2, 4, 9, 6 });
            printArray(arr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr=insertSort(new int[] { 3, 3, 2, 4, 7, 6 });
            printArray(arr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr = { 3, 3, 2, 4, 8, 6 };
            mergeSort(arr,0,arr.Length-1);
            printArray(arr);
        }
    }
}
