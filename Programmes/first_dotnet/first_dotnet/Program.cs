namespace first_dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello obj=new SayHello();
            obj.Hello();
        }
    }

    public class SayHello
    {

        public void Hello()
        {
            Console.WriteLine("Hello All.I welcome you all to my Workspace.");
        }
    }
}
