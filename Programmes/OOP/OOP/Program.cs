using Demo.Logic;
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person();
            person.first_name = "Sachin";
            person.last_name = "Tendulkar";
            Console.WriteLine(person);// fully qualified name _06Demo_OOP_Inheritance.logic.Person
            Console.WriteLine("Name : {0} {1}", person.first_name, person.last_name); 
            

            
            Employee employee = new Employee();
            employee.employee_id = 2002;
            Console.WriteLine("ID: {2}, Name : {0} {1} {2}", person.first_name, person.last_name, employee.employee_id);
          
        }
    }
}
