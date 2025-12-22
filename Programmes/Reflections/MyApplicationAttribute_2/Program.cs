using MyApplication_Attributes;
using System.Reflection;


namespace MyApplicationAttribute_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"C:\Users\IET\Desktop\250845920099\.NET\Daily_Work\Programmes\Reflections\StudeLib\bin\Debug\net8.0\MyApplication_Attributes3.dll";
            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] alltypes= asm.GetTypes();
            
            for (int i = 0; i < alltypes.Length; i++) {
                Type type= alltypes[i];
                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                Attribute attr = allAttributes[i];
                if (attr is  BonaVentureSystems)
                {
                    BonaVentureSystems  bvsattr= attr as BonaVentureSystems;
                    Console.WriteLine($"Class  is developed by {bvsattr.Developer_Name} of (c) {bvsattr.Company_Name}");
                }
            }
        }
    }
}
