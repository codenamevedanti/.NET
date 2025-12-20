namespace Generic_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Student stud1 = new Student();
            stud1.sid = 101;
            stud1.sname = "Rajas";
            stud1.marks = 90;

            Student stud2 = new Student();
            stud2.sid = 102;
            stud2.sname = "Mandar";
            stud2.marks = 78;

            Student stud3 = new Student();
            stud3.sid = 103;
            stud3.sname = "Shivani";
            stud3.marks = 45;

            Student stud4 = new Student();
            stud4.sid = 104;
            stud4.sname = "Meenakshi";
            stud4.marks = 57;

            Student stud5 = new Student();
            stud5.sid = 105;
            stud5.sname = "Sunil";
            stud5.marks = 89;

            //List <Student> list = new List<Student>();
            //list.Add(stud1);
            //list.Add(stud2);
            //list.Add(stud3);
            //list.Add(stud4);
            //list.Add(stud5);
            //foreach (Student student in list) {
            //    Console.WriteLine($"Student id is:{student.sid} \n Student name is:{ student.sname}\n Student marks is:{ student.marks}");
            //    if (student.marks > 65)
            //    {
            //        Console.WriteLine("CONGRATULATIONS,you are passed.");
            //    }
            //    else {
            //        Console.WriteLine("Sorry.You are failed");
            //    }
            //    Console.WriteLine("\n");
            //}

            Dictionary<int, Student> studDict = new Dictionary<int, Student>();
            studDict.Add(stud1.sid, stud1);
            studDict.Add(stud2.sid, stud2);
            studDict.Add(stud3.sid, stud3);
            studDict.Add(stud4.sid, stud4);
            studDict.Add(stud5.sid, stud5);
            foreach (KeyValuePair<int, Student> element in studDict)
            {
                Student emp = element.Value;
                //element.Key
                Console.WriteLine($"Id: {emp.sid}, Name: {emp.sname}, Marks : {emp.marks}");
            }
            //foreach (int key in studDict.Keys)
            //{
            //    Student emp = studDict[key] as Student;
            //    Console.WriteLine($"Key = {key}, Id: {emp.sid}, Name: {emp.sname}, Marks : {emp.marks}");
            //}
            foreach (Student emp in studDict.Values)
            {

                Console.WriteLine($"Id: {emp.sid}, Name: {emp.sname}, Marks : {emp.marks}");
            }


        }
    }
    public class Student {
        private int _sid;
        private string _sname;
        private int _marks;

        
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

        public int marks
        {
            get { return _marks; }
            set { _marks = value; }
        }




    }
}
