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
         List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static String arrayToString(int[] array)
        {
            String a = "[";
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                    a = a + array[i] + " , ";
                else
                    a += array[i];
            }
            a += "]";
            return a;
        }


        public static void addNumber(NumericUpDown inputNumber)
        {
            inputNumber.Value=0;
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
            int[] countArray = new int[max+1];

            for(int i=0;i<arr.Length;i++)
            {
                countArray[arr[i]]++;
            }
            for (int i = 1; i < countArray.Length; i++)
                countArray[i] = countArray[i - 1] + countArray[i];

            int[] outputArray = new int[arr.Length];
            for (int i = arr.Length-1; i >= 0; i--)
                outputArray[countArray[arr[i]] - 1] = arr[i];

            return outputArray;
        }

        static void QuickSort(int[] array, int low, int high)
        {

            if (low < high)
            {

                int pivot = Partition(array, low, high);

                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);

            }

        }

        static int Partition(int[] array, int low, int high)
        {

            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {

                if (array[j] < pivot)
                {

                    i++;

                    Swap(array, i, j);

                }

            }

            Swap(array, i + 1, high);

            return i + 1;

        }

        static void Swap(int[] array, int i, int j)
        {

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

            private void Button1_Click(object sender, EventArgs e)
        {
            int[] arr = list.ToArray();
            arr=bubbleSort(arr);
            label2.Text = arrayToString(arr);

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr= list.ToArray();
            arr=insertSort(arr);
            label2.Text = arrayToString(arr);
        }

        private void button3_Click(object sender, EventArgs e)
        {      
            int[] arr = list.ToArray();
            mergeSort(arr, 0, arr.Length - 1);
            label2.Text = arrayToString(arr);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            int[] arr = list.ToArray();
            QuickSort(arr,0,arr.Length-1);
            label2.Text = arrayToString(arr);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] arr = list.ToArray();
            arr=countingSort(arr);
            label2.Text = arrayToString(arr);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] arr = list.ToArray();
            arr = countingSort(arr);
            label2.Text = arrayToString(arr);
        }

        private void NumberAdd_Click(object sender, EventArgs e)
        {
            int data =(int) inputNumber.Value;
            list.Add(data); 
            label1.Text=arrayToString(list.ToArray());
            inputNumber.Value = 0;
        }

        
    }
}
