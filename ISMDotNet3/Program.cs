using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMDotNet3
{
    class Program
    {
        public static double[] ArrayInput()
        {
            int n;
            
            Console.Write("Input Array Count: ");
            n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            double f;
            for(int i = 0; i < arr.Length; i++)
            {
                
                bool flag = false;
                do
                {
                    Console.Write($"Array[{i}] = ");
                    flag = double.TryParse(Console.ReadLine(), out f);
                    if (flag == true)
                    {
                        arr[i] = f;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                } while (flag == false);

            }
            return arr;
        }
        public static double NegativeElementSum(double[] arr)
        {
            double n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    n += arr[i];
            }
            return n;
        }
        public static int PositiveIndexCount(double []arr)
        {
            int n = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    n++;
            }
            return n;
        }
        public static int PositiveIndexSum(double[] arr)
        {
            int q = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    q += i;
            }
            return q;
        }
        public static int MaxElementIndex(double []arr)
        {
            double n = arr[0];
            int q = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if(n < arr[i])
                {
                    n = arr[i];
                    q = i;
                }
            }
            return q;
        }
        public static double MaxElement(double[] arr)
        {
            /*         double n = arr[0];

                     for (int i = 1; i < arr.Length; i++)
                     {
                         if (n < arr[i])
                         {
                             n = arr[i];     
                         }
                     }
                    return n;
            */
            return (arr[MaxElementIndex(arr)]);
        }
        public static double MaxAbsoluteElement(double[] arr)
        {
            double n = Math.Abs(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (n < Math.Abs(arr[i]))
                {
                    n = arr[i];
                }
            }
            return n;
        }

        public static int IntegerCount(double[] arr)
        {
            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Floor(arr[i]) == arr[i])
                    n++;
            }
            return n;
        }
        public static double[] DescendingSort(double[] arr)
        {
            Array.Sort<double>(arr);
            Array.Reverse(arr);
            return arr;
        }
        public static double[] DeleteNegativeElements(double[] arr)
        {
            double[] arr2 = new double[PositiveIndexCount(arr)];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr2[j] = arr[i];
                   // Console.WriteLine($"{arr2[j]}");
                    j++;
                    
                }
                    
            }
            return arr2;
        }
        public static void ArrayOutput(double[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {arr[i]}");
            }
        }
        static void Main(string[] args)
        {
            //Тут різні перевірки
            double[] arr = ArrayInput();
            Console.WriteLine($"{NegativeElementSum(arr)}");
            Console.WriteLine($"{PositiveIndexCount(arr)}");
            Console.WriteLine($"{MaxElementIndex(arr)}");
            Console.WriteLine($"{MaxAbsoluteElement(arr)}");
            Console.WriteLine($"{MaxElement(arr)}");
            Console.WriteLine($"{IntegerCount(arr)}");
      
            arr = DeleteNegativeElements(arr);
            ArrayOutput(arr);
            
        }
    }
}
