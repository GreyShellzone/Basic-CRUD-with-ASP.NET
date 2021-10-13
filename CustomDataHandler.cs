﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasicCRUD
{
    public class CustomDataHandler
    {
        static SqlConnection connection = new SqlConnection("Data Source=SHELLZONE-PC\\MSSQLSERVER01;Initial Catalog=BasicCRUD;Integrated Security=True");
        
        static string StudentTable = "StudentInfo_Tab";

        static string StudentTableID = "StudendID";
        static string StudentTableName = "StudentName";
        static string StudentTableAdress = "Adress";
        static string StudentTableAge = "Age";
        static string StudentTableContact = "Contact";

        public static void CreateRecord(string ID, string Name, string Adress, string Age, string Contact)
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

        public static DataTable ReadAll()
        {
            SqlCommand command = new SqlCommand("Select * From " + StudentTable, connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            return dt;
        }

        public static DataTable ReadOne(string ID)
        {
            SqlCommand command = new SqlCommand(
                "Select * From " + 
                    StudentTable +
                " Where " +
                    StudentTableID + " = '"+ int.Parse(ID) + "'",
            connection);

            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            return dt;
        }

        public static void UpdateRecord(string ID, string Name, string Adress, string Age, string Contact)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(
                "Update " + StudentTable + " set " +
                    StudentTableName + " = '" + Name + "'," +
                    StudentTableAdress + " = '" + Adress + "'," +
                    StudentTableAge + " = '" + int.Parse(Age) + "'," +
                    StudentTableContact + " = '" + Contact + "'" +
                "Where " +
                    StudentTableID + " = '" + int.Parse(ID) + "'",
            connection);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteRecord(string ID)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(
                "Delete From " + StudentTable + " Where " +
                    StudentTableID + " = '" + int.Parse(ID) + "'",
            connection);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}