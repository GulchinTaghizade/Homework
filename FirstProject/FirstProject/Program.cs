﻿using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] massiv = { 3, 5, 7 };
            //int number = 9;
            //AddNumber(ref massiv, number);
            //foreach (var item in massiv)
            //{
            //    Console.WriteLine(item);
            //}


            //string name = "Hikmet Aliyev";
            //Console.WriteLine(SpaceRemover(ref name));
            //Console.WriteLine(name);


            //int num = 34;
            //Console.WriteLine(NearestSqrt(ref num));
            //Console.WriteLine(num);
        }

        #region C# methods
        //static int MaxNumber(params int[] arr) //Task1
        //{
        //    int max = arr[0];
        //    foreach (var item in arr)
        //    {
        //        if (item > max)
        //        {
        //            max = item;

        //        }
        //    }
        //    return max;

        //}

        //static int NumOfOnes(int num) //Task2
        //{
        //    string Result = "";
        //    for (int i = 0; num > 0; i++)
        //    {
        //        Result = num % 2 + Result;
        //        num = num / 2;
        //    }
        //    int count = 0;
        //    for (int i = 0; i < Result.Length; i++)
        //    {
        //        if (Result[i]%2 == 1)
        //        {
        //            count++;
        //        }

        //    }
        //    return count;

        //}
        #endregion

        #region String. StringBuilder
        static int indexOf(char value)     //Task1.1
        {
            string text = "salamlar";
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == value)
                {
                    return i;

                }
            }
            return result;
        }

        static int indexOf(char value, int index)     //Task1.2
        {
            string text = "salamlar";
            int result = 0;
            for (int i = index; i < text.Length; i++)
            {
                if (text[i] == value)
                {
                    return i;

                }
            }
            return result;
        }


        static int indexOf(char value, int index, int count)     //Task1.3
        {
            string text = "salamlar";
            int result = 0;
            for (int i = index; i < count; i++)
            {
                if (text[i] == value)
                {
                    return i;

                }
            }
            return result;
        }



        static StringBuilder reverse(string value)              //Task2
        {
            StringBuilder revValue = new StringBuilder();
            for (int i = value.Length - 1; i >= 0; i--)
            {

                revValue.Append(value[i]);

            }
            return revValue;
        }

        #endregion

        #region C# ref/out
        // TASK1
        static void AddNumber(ref int[] arr, int num) 
        {
            int[] array = new int[arr.Length + 1];
            foreach (var item in arr)
            {

                Console.WriteLine(item);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
            array[arr.Length] = num;
            arr = array;
        }

        //TASK2
        static StringBuilder SpaceRemover(ref string value)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != ' ')
                {
                    result.Append(value[i]);
                }
            }
            value = result.ToString();
            return result;

        }

        //TASK3
        static int NearestSqrt(ref int num)
        {
            int result = 1;
            for (int i = 1; i*i <= num; i++)
            {
                result = i;
            }
            num = result;
            return result;
        }

        #endregion
    }
}
