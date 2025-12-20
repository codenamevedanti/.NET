using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serilizable_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath1 = @"C:\Users\IET\Desktop\250845920099\.NET\Daily_Work\Programmes\Serilizable_demo\data.xml";
            string filepath2 = @"C:\Users\IET\Desktop\250845920099\.NET\Daily_Work\Programmes\Serilizable_demo\data.json";
            Student stud=new Student();
            stud.id = 1;
            stud.name = "Neelema";
            stud.marks = 99;
            Type type=stud.GetType();
            XmlSerializer xr = new XmlSerializer(type);

             FileStream fs = null;

            if (File.Exists(filepath1))
            {
                fs = new FileStream(filepath1, FileMode.Create, FileAccess.Write);
            }
            else
            {
               fs = new FileStream(filepath1, FileMode.OpenOrCreate, FileAccess.Write);
            }

            XmlSerializer xr1 = new XmlSerializer(typeof(Student));
            xr.Serialize(fs, stud);
            fs.Close();
            Console.WriteLine(" Xml Serialization Done");

            FileStream fs2 = null;

            if (File.Exists(filepath1))
            {
               fs2 = new FileStream(filepath1, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

            XmlSerializer xr2 = new XmlSerializer(typeof(Student));
            Student studData = xr2.Deserialize(fs2) as Student;
            fs2.Close();
            Console.WriteLine($"Id = {studData.id}, Name = {studData.name}, Marks= {studData.marks}");


            FileStream fsjson = null;

            if (File.Exists(filepath2))
            {
                fsjson = new FileStream(filepath2, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fsjson = new FileStream(filepath2, FileMode.OpenOrCreate, FileAccess.Write);
            }
            JsonSerializer.Serialize<Student>(fsjson, studData);
            fsjson.Close( );
            Console.WriteLine("Json Serialization done");

            FileStream fsjson1 = null;

            if (File.Exists(filepath2))
            {
                fsjson1 = new FileStream(filepath2, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fsjson1 = new FileStream(filepath2, FileMode.OpenOrCreate, FileAccess.Write);
            }
            JsonSerializer.Serialize<Student>(fsjson1, studData);
            fsjson1.Close();
            Console.WriteLine($"Id = {stud.id}, Name = {stud.name}, Marks= {stud.marks}");


        }
    }
    public class Student { 
      private int _id;
        private string _name;
        private int _marks;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        [XmlIgnore]
        [JsonIgnore]
        public int marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

    } 
}
