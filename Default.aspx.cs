using System;
using System.Collections.Generic;
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
            if(BasicChecking(StudentIDValue.Text, StudentNameValue.Text, AdressValue.Text, AgeValue.Text, ContactValue.Text))
            {
                CustomDataHandler.CreateRecord(StudentIDValue.Text, StudentNameValue.Text, AdressValue.Text, AgeValue.Text, ContactValue.Text);
                EmptyingForm();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succesfully Registered')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Check your Records')", true);
            }
            LoadRecord();
        }

        void LoadRecord()
        {
            RecordTable.DataSource = CustomDataHandler.ReadAll();
            RecordTable.DataBind();
        }

        bool BasicChecking(string ID, string Name, string Adress, string Age, string Contact)
        {
            bool Validation = true;

            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(Name) || Adress.Equals("Select") || string.IsNullOrEmpty(Age) || string.IsNullOrEmpty(Contact))
                Validation = false;

            return Validation;
        }

        void EmptyingForm()
        {
            StudentIDValue.Text = String.Empty;
            StudentNameValue.Text = String.Empty;
            AdressValue.SelectedIndex = 0;
            AgeValue.Text = String.Empty;
            ContactValue.Text = String.Empty;
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            if (BasicChecking(StudentIDValue.Text, StudentNameValue.Text, AdressValue.Text, AgeValue.Text, ContactValue.Text))
            {
                CustomDataHandler.UpdateRecord(StudentIDValue.Text, StudentNameValue.Text, AdressValue.Text, AgeValue.Text, ContactValue.Text);
                EmptyingForm();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succesfully Updated')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Check your Records')", true);
            }
            LoadRecord();
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(StudentIDValue.Text))
            {
                CustomDataHandler.DeleteRecord(StudentIDValue.Text);
                EmptyingForm();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succesfully Deleted')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Check your Records')", true);
            }
            LoadRecord();
        }
    }
}