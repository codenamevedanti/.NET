
//using C_Features.Add;
using System;
    namespace C_Features
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CMath cmath = new CMath();

            #region partial class
            Console.WriteLine("Enter the value of x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($" Add {cmath.add(x, y)}");
            if (x < y)
            {
                Console.WriteLine($"Sorry operation cannot be performed since {x} is less than {y}!!!");
            }
            else
            {
                Console.WriteLine($" Subtract {cmath.sub(x, y)}");
            }
                
            Console.WriteLine($" Multiply {cmath.mul(x,y )}");
            #endregion

            #region Object Initializer
            string name = null;
            Demo demo = new Demo() { _id = 100 };
            Console.WriteLine(demo._id);

            Demo demo1 = new Demo() { _name = "Hugh Jackman", _id = 111 };
            Console.WriteLine(demo1._name + " " + demo1._id);
            Console.WriteLine("Enter name:");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter the description:");
            string des = Console.ReadLine();

            Demo demo2 = new Demo() { _name = nm, _decription = des };

            Console.WriteLine($"Name = {demo2._name}, Description= {demo2._decription}");
            #endregion


            #region AutoProperties

            Emp emp = new Emp()
            {
                EId = 202,
                EName = "John Wick",
                isActive = false,
                Salary = 4000,
                DOJ = DateTime.Now,
                Projects = new List<string>() { "Hospital Management System", "Advanced Data Cleaning App", "Payment Inferface of MyPay Application" }
            };
            Console.WriteLine($"DOJ = {emp.DOJ.ToString()}");
            foreach (string str in emp.Projects)
            {
                Console.WriteLine(str);
            }
            #endregion


        }


    }

    public class Holder
    {
        public int? id { get; set; }  
        public string? name { get; set; }
        public string? address { get; set; }
    }

public class Emp
{
    private int _Id;

    //public int EId
    //{
    //    get { return _Id; }
    //    set { _Id = value; }
    //}


    public int EId { get; set; }
    public string EName { get; set; }
    public bool isActive { get; set; }
    public double Salary { get; set; }
    public DateTime DOJ { get; set; }
    public List<string> Projects { get; set; }
    public Demo demo { get; set; }

}

    public class Demo 
    {
        public string _name;
        public int _id;
        public string _decription;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string decription
        {
            get { return _decription; }
            set { _decription = value; }
        }



    }
}
