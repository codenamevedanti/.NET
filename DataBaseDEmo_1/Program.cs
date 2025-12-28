using Microsoft.Data.SqlClient;

namespace DataBaseDEmo_1
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Emp;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectQuery = "select * from Employee";
            SqlCommand cmd = new SqlCommand(selectQuery);
            cmd.CommandType=System.Data.CommandType.Text;
            cmd.CommandText=selectQuery;
            cmd.Connection = con;
            con.Open();
             SqlDataReader reader =cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string Name = reader["Name"].ToString();
                string? Dept = reader["Department"].ToString();
                Console.WriteLine($"Id:{id},Name:{Name},Department:{Dept}");
            }


            con.Close();

        }
    }
}
