namespace LINQ_DEMO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region predicateDelegate
            //Predicate<int> Even = x => x % 2 == 0;
            //Predicate<int> Odd = x => x % 2 != 0;
            //Console.WriteLine("Enter a number:");
            //int num=Convert.ToInt32(Console.ReadLine());

            //var EvenResult = Even(num);
            //var OddResult = Odd(num);
            //Console.WriteLine($"The Number {num}--->Even: {EvenResult}, Odd: {OddResult}");

            #endregion

            #region Func<out Result>
            Func<double> func1 = delegate ()
            {
                return 19.67+21.8678;
            };
            var result = func1();
            Console.WriteLine(result);

            Func<double> func3 = () => { return 16.666; };

            var result3 = func3();
            Console.WriteLine(result3);

            Func<string> func2 = delegate ()
            {
                return "Charlie Chaplin";
            };
            var result2 = func2();
            Console.WriteLine(result2);
            #endregion
        }
    }
}
