namespace DelegateExample2
{
    public delegate void MyEventHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is Sports faculty  present?");
            string isPresent = Console.ReadLine();
            Timetable obj = new Timetable();
            {
                MyEventHandler handler = obj.prayer;

                if (isPresent == "yes")
                {
                    handler += obj.Sports;
                }
                else
                {
                    handler -= obj.Sports;

                }
                handler += obj.Maths;
                handler += obj.Break;
                handler += obj.Science;
                handler += obj.Leave;
                handler();




            }
        }
        public class Timetable()
        {
            public void prayer()
            {
                Console.WriteLine("Saraswati Vandana");
            }

            public void Sports()
            {
                Console.WriteLine("This is Football time!!!!");
            }

            public void Maths()
            {
                Console.WriteLine("Lets learn algebra");

            }
            public void Break() {
                Console.WriteLine("This is Lunch Time");
            }

            public void Science() {
                Console.WriteLine("Lets Learn Chemistry.");
            }

            public void Leave() {
                Console.WriteLine("Go home.");
            }
}
                
                }
    }

