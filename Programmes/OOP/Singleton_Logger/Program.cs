namespace Singleton_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your Database choice: 1.Sql Server \n 2.Oracle Server \n 3.MySql Server");
                int dbchoice = Convert.ToInt32(Console.ReadLine());

                DataBaseFactory factory = new DataBaseFactory();
                Database ob = factory.GetSomeDatabase(dbchoice);

                Console.WriteLine("Choose Operation: 1.Insert  2.Update  3.Delete");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ob.Insert();
                        break;
                    case 2:
                        ob.Update();
                        break;
                    case 3:
                        ob.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? yes/no");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "no")
                {
                    break;
                }
            }
        }
    }

    // ================= DATABASE BASE CLASS =================
    public abstract class Database
    {
        public Logger _logger = null;

        public Database()
        {
            _logger = Logger.GetLogger();
        }

        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract string GetDataBaseName();

        public void Insert()
        {
            DoInsert();
            _logger.Log($"Insert From {GetDataBaseName()} done.");
        }

        public void Update()
        {
            DoUpdate();
            _logger.Log($"Update From {GetDataBaseName()} done.");
        }

        public void Delete()
        {
            DoDelete();
            _logger.Log($"Delete From {GetDataBaseName()} done.");
        }
    }

    // ================= FACTORY =================
    public class DataBaseFactory
    {
        public Database GetSomeDatabase(int dbchoice)
        {
            Database db = null;

            switch (dbchoice)
            {
                case 1:
                    db = new SqlServer();
                    break;
                case 2:
                    db = new OracleServer();
                    break;
                case 3:
                    db = new MySqlServer();
                    break;
                default:
                    Console.WriteLine("Invalid Database Choice");
                    break;
            }
            return db;
        }
    }

    // ================= DATABASE IMPLEMENTATIONS =================
    public class SqlServer : Database
    {
        protected override string GetDataBaseName()
        {
            return "Sql Server";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in SqlServer Successfully");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in SqlServer Successfully");
        }

        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from SqlServer Successfully");
        }
    }

    public class MySqlServer : Database
    {
        protected override string GetDataBaseName()
        {
            return "MySQL Server";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in MySql Successfully");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in MySql Successfully");
        }

        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from MySql Successfully");
        }
    }

    public class OracleServer : Database
    {
        protected override string GetDataBaseName()
        {
            return "Oracle Server";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in OracleServer Successfully");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in OracleServer Successfully");
        }

        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from OracleServer Successfully");
        }
    }

    // ================= LOGGER (SINGLETON) =================
    public class Logger
    {
        private static readonly Logger _logger1 = new Logger();

        private Logger()
        {
            Console.WriteLine("Logger Object is created for the first time!..");
        }

        public static Logger GetLogger()
        {
            return _logger1;
        }

        public void Log(string message)
        {
            Console.WriteLine("---Logged at {0}, message : {1}",
                DateTime.Now.ToString(), message);
        }
    }
}
