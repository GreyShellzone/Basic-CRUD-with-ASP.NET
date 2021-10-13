using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicCRUD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=SHELLZONE-PC\\MSSQLSERVER01;Initial Catalog=BasicCRUD;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into StudentInfo_Tab values ('" + int.Parse(StudentIDValue.Text) + "', '" + StudentNameValue.Text + "', '" + AdressValue.Text + "', '" + int.Parse(AgeValue.Text) + "', '" + ContactValue.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succesfully Registered')", true);
        }
    }
}