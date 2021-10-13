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
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            CustomDataHandler.InsertRecord(StudentIDValue.Text, StudentNameValue.Text, AdressValue.Text, AgeValue.Text, ContactValue.Text);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succesfully Registered')", true);

            LoadRecord();
        }

        void LoadRecord()
        {
            RecordTable.DataSource = CustomDataHandler.Records();
            RecordTable.DataBind();
        }

    }
}