namespace MyDelegates
{
    internal class Program
    {
         public  delegate void MyNameDelegate(string name);
         public  delegate void  MyMarksDelegates(int mrk);
        static void Main(string[] args)
        {
            MyNameDelegate del1 = new MyNameDelegate(Myname);
            MyMarksDelegates del2 = new MyMarksDelegates(MyMarks);

            del1("Priya");
            del2(67);

            static void Myname(String name) {
                
                Console.WriteLine($"My name is {name}");
            }

            static void MyMarks(int mrk) {

                Console.WriteLine($"My marks is {mrk}");

            }
           
        }
    }
}
