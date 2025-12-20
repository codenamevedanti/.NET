using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialzation_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\IET\Desktop\250845920099\.NET\MyDelegates\FileIO_demo\BinarySerialzation_demo\data.txt";
            Student s = new Student();
            s.sid = 1;
            s.sname = "Naresh";
            s.age = 16;
            s.hobby = "Sketchig";

            FileStream fs = null;
            if (File.Exists(filepath))
            {
                fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            }
            else {
                fs = new FileStream(filepath,FileMode.OpenOrCreate,FileAccess.Write);
            }
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s);
            fs.Close();
            Console.WriteLine("Done.");

        }
    }
    [Serializable]
    public class Student {
        private int _sid;
        private string _sname;
        [NonSerialized]
        private int _age;
        [NonSerialized]
        private string _hobby;

        

        public int sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

        public string sname
        {
            get { return _sname; }
            set { _sname = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }


    }
}
