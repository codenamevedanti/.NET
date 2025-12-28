namespace LINQ_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>()
            {
             new Product() {_pid=101,_pname="Keyboard",_type="Electronics" },
              new Product() {_pid=102,_pname="Chair",_type="Furniture"},
              new Product() {_pid=103,_pname="Laptop",_type="Electronics" },
               new Product() {_pid=104,_pname="Biscuits",_type="Grocery" },
               new Product() {_pid=105,_pname="Ipad",_type="Electronics" },
               new Product() {_pid=106,_pname="Mouse",_type="Electronics" },
               new Product() {_pid=107,_pname="Milk",_type="Grocery" },
               new Product() {_pid=108,_pname="Sofa",_type="Furniture" },
               new Product() {_pid=109,_pname="Nachos",_type="Grocery" },
                new Product() {_pid=110,_pname="Table",_type="Furniture" },
            };
            #region filter product types
            Console.WriteLine("Enter your product type:");
            string? product=Console.ReadLine().ToLower();

            Func<Product,bool> del=pd=>pd._type.ToLower() == product;
            bool found = false;
           
            foreach(Product prod in p)
            {
                if (del(prod))
                {
                    Console.WriteLine($" The Product Id is:{prod._pid} \n The Product Name is:{prod._pname}\n The Product Type is:{prod._type}");
                    Console.WriteLine("-----------------------------------------------");
                }
            }
            if (!found)
            {
                Console.WriteLine("No products for that type!!!");
            }



            #endregion
        }
    }

    public class Product
    {
        //auto properties
        public int _pid {  get; set; } 
        public string _pname {  get; set; }
        public string _type { get; set; }
    }
}
