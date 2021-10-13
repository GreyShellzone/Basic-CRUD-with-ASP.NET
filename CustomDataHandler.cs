using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasicCRUD
{
    public class CustomDataHandler
    {
        static string StudentTable = "StudentInfo_Tab";
        static SqlConnection connection = new SqlConnection("Data Source=SHELLZONE-PC\\MSSQLSERVER01;Initial Catalog=BasicCRUD;Integrated Security=True");

        public static void InsertRecord(string ID, string Name, string Adress, string Age, string Contact)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(
                "Insert into "
                    + StudentTable + 
                " values ('" + int.Parse(ID) + "', '" + Name + "', '" + Adress + "', '" + int.Parse(Age) + "', '" + Contact + "')"
                , connection);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable Records()
        {
            SqlCommand command = new SqlCommand("Select * From " + StudentTable, connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            return dt;
        }
    }
}