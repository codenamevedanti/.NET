using Entity_Framework.DAL;
using Entity_Framework.Models;
using System.Linq;
using System.Collections.Generic;

IETDbContext _DbContext = new IETDbContext();
while (true)
{
   
    Console.WriteLine("1. Select\n2.Insert\n 3.Update\n4.Delete");
    Console.WriteLine("Enter your Db Operation Choice:");
    int opChoice = Convert.ToInt32(Console.ReadLine());
    switch (opChoice)
    {
        case 1:
            List<Emp> allEmps = _DbContext.emps.ToList();
            foreach (var emp in allEmps)
            {
                Console.WriteLine("Id:{emp.Id}\n Name:{emp.Name}\n Address:{emp.address}");
            }
            break;

        case 2:
            break;

        case 3:
            break;

        case 4:
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;


    }


}
