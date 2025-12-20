using System.Reflection;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"C:\Users\IET\Desktop\250845920099\.NET\Daily_Work\Programmes\Reflections\Reflections\bin\Debug\net8.0\demo.dll";

            Assembly asm = Assembly.LoadFrom(assemblyPath);

            Type[] allTypes = asm.GetTypes();

            foreach (Type type in allTypes)
            {
              
                if (type.IsAbstract || type.IsInterface)
                    continue;

                object obj = Activator.CreateInstance(type);

                MethodInfo[] methods = type.GetMethods(
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly); 

                foreach (MethodInfo method in methods)
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    object[] inputValues = new object[parameters.Length];

                    Console.WriteLine($"\nCalling Method: {method.Name}");

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.WriteLine($"Enter value for {parameters[i].Name} ({parameters[i].ParameterType.Name})");
                        inputValues[i] =
                            Convert.ChangeType(Console.ReadLine(), parameters[i].ParameterType);
                    }

                    object result = method.Invoke(obj, inputValues);

                    if (method.ReturnType != typeof(void))
                    {
                        Console.WriteLine($"Result = {result}");
                    }
                }
            }
        }
    }
}
