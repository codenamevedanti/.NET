namespace Generic_demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter  a number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Calculator c=new Calculator();
            //c.Fact(n);

            Console.WriteLine("Enter the length of rectangle:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth of rectangle:");
            int b = Convert.ToInt32(Console.ReadLine());
            
            
            
            
            
           Calculator c2 = new Calculator();
            c2.RectangleArea(a, b);



        }

        public class Calculator { 

            public void Fact (long n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;

                }
                Console.WriteLine(fact);
            }
            public void RectangleArea(int a, int b) {
                int area ;
                area = a * b;
                Console.WriteLine($"The area of rectangle is:{area}");
            }
            public R Demo<P, Q, R, S>(P x, Q y, R a, S b)
            {
                return a;
            }

        }
        
    }
}
