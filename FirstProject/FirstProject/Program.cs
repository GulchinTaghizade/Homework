using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(indexOf('l'));
            // Console.WriteLine(indexOf('l',2));
            // Console.WriteLine(indexOf('a', 2, 4));
            //string str = "Ibrahim yaxşı oğlandı"; 
            //Console.WriteLine(reverse("Ibrahim yaxşı oğlandı"));
        }

        #region 16/03/2022
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

        #region 17/03/2022
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
            for (int i = value.Length-1; i >=0; i--)
            {
               
                    revValue.Append(value[i]);
               
            }
            return revValue;
        }

        #endregion

    }
}
