using System;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Методи розширення");

            Console.WriteLine("\nПеревертень int");
            int num = 123456789;
            Console.WriteLine(num);
            num.Reverse();
            Console.WriteLine();

            Console.WriteLine("\nПеревертень string");
            string str = "Hello World!";
            Console.WriteLine(str);
            str.Reverse();
            Console.WriteLine();

            Console.WriteLine("\nПеревертень double");
            double dNum = 123.567;
            Console.WriteLine(dNum);
            dNum.Reverse();
            Console.WriteLine();

            //reverse array
            Console.WriteLine("\nПеревертень массиву int");
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr.Reverse();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("\nЗворотнє виведення");
            int[] revArr = { 95, 65, 1, 9, 577, 0, 49 };

            revArr.ReverseOutput();
        }
    }

    public static class IntExtensionMethods
    {
        public static void Reverse(this int num)
        {

            Console.Write(num % 10);
            while ((num /= 10) != 0) {

                Console.Write(num % 10);
            }
        }
        public static void Reverse(this string str)
        {
            char[] strArr = str.ToCharArray();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(strArr[i]);
            }
        }
        public static void Reverse(this double dNum)
        {
            string[] splitedStr = dNum.ToString().Split(',');

            for (int j = splitedStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[0][j]);
            }
            Console.Write(",");
            for (int j = splitedStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[1][j]);
            }
        }
        public static void Reverse(this int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;

                left++;
                right--;
            }
        }
        public static void ReverseOutput(this int[] revArr)
        {
            Array.Reverse(revArr)
            for (int i = 0; i < revArr.Length; i++)
            {
                Console.Write(revArr[i] + " ");
            }
            Console.WriteLine();
        }

    }

}
