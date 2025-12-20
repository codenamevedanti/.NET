namespace FileIO_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\250845920099\.NET\MyDelegates\FileIO_demo\FileIO_demo\demo.txt";
            FileStream fs = null;
            if (File.Exists(filePath))
                {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(1001);
            writer.WriteLine(28);
            writer.WriteLine("Emma Watson");
            writer.Flush();
            writer.Close();
            fs.Close();
            Console.WriteLine("Done");

            Student stud=new Student();
            stud.sid = 1009;
            stud.age = 25;
            stud.sname = "Sachin Singh";

            FileStream fs1 = null;
            if (File.Exists(filePath))
            {
                fs1 = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs1 = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }
            StreamWriter writer1=new StreamWriter(fs1);
            writer1.Write(stud);
            writer1.Flush();
            writer1.Close();
            fs.Close();
            Console.WriteLine("Done.");







        }
    }

    public class Student {
        private int _sid;
        private int _age;
        private string _sname;

        public int sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string sname
        {
            get { return _sname; }
            set { _sname = value; }
        }


    }
}
