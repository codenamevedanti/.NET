//using System.Reflection.Metadata.Ecma335;
using System;

namespace C__Features
{
    public delegate bool Delegate(int x, int y, out int result, out int product);
    public delegate int MyDelegate(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region normal function check method
            //Console.WriteLine("Enter the number :");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the number :");
            //int b = Convert.ToInt32(Console.ReadLine());

            //bool isSumGreater = Add(a, b, out int result, out int product);

            //if (isSumGreater)
            //{
            //    Console.WriteLine($"The sum {result} is greater then their product {product}");
            //}
            //else
            //{
            //    Console.WriteLine($"The sum {result} is not greater then their product {product}");
            //}
            #endregion

            #region function with delegate

            //Delegate del = new Delegate(Add);
            //bool isSumGreater = del(a, b, out int result, out int product);

            //if (isSumGreater)
            //{
            //    Console.WriteLine($"The sum {result} is greater then their product {product}");
            //}
            //else
            //{
            //    Console.WriteLine($"The sum {result} is not greater then their product {product}");
            //}
            #endregion

            #region Anonymous method

            //MyDelegate del2 = new MyDelegate(delegate (int a, int b)
            //{
            //    return a + b;
            //});
            //
            //var output = del2(a, b);
            //Console.WriteLine($"The sum of {a} & {b} is : {output}.");
            //
            //if (output > 15)
            //{
            //    Console.WriteLine($"The sum {output} is greater then 15.");
            //    int fact = 1;
            //    for (int i = 1; i <= output; i++)
            //    {
            //        fact = fact * i;
            //    }
            //    Console.WriteLine($"The factorial of {output} is {fact}.");
            //}
            //else
            //{
            //    Console.WriteLine($"The sum {output} is less then 15.");
            //}
            #endregion

            #region In-built sum

            //int[] arr = [1, 2, 3, 6, 7];
            //var result = arr.Sum();
            //Console.WriteLine($"The of sum of array [{string.Join(",",arr)}]is {result}.");
            string[] names =new string[] { "Tom", "Holland", "Angelina", "Matthews", "Robert", "Thomas", "David" };
            var resultNames = Sum(names);
            //var result = names.Sum();
            Console.WriteLine(resultNames+",");

            #endregion

            #region valid email id checking code
            //Console.WriteLine("Enter your Email ID:");
            //string? email = Console.ReadLine();

            //if (email != null)
            //{
            //    if (email.CheckForValidEmailID())
            //        Console.WriteLine("Valid Email id");
            //    else
            //        Console.WriteLine("Invalid Email Id");
            //}
            #endregion
        }
       
       

        public static bool Add(int a, int b, out int result, out int product)
        {
            result = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {result}.");

            product = a * b;
            Console.WriteLine($"The product of {a} and {b} is {product}.");

            return result > product;
        }

        public static T Sum<T>(IEnumerable <T> arr)
            {
             dynamic sum = 0;
            dynamic sum2 = " ";
            foreach (var ele in arr)
            {
                sum += ele;
                sum2 += ele;
         
            }
            return sum2;
           

        }
    }
    public static class MyClass
    {
        public static bool CheckForValidEmailID(this string email)
        {
            return email.Contains("@gmail==.com");
        }
    }
}
