namespace DataTpes_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHoliday = true;
            if (isHoliday)
            {
                Console.WriteLine("Go For Outing!!!");
            }
            else
            {
                Console.WriteLine("Go to college.");
            }

            for (int i = 1; i < 10; i++)
            { 
                for(int j = 1; j < i - 1; j++) 
                { 
                    Console.Write("*"); 
                }
                Console.WriteLine();
               
            }

            int x = 8;
            while (x <=17) {
                Console.Write(x*x);
                Console.WriteLine();
                x++;

            }
        }
    }
}
