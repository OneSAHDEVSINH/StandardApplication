using StandardApplication.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StandardApplication.DAL;

namespace StandardApplication
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CityProvider cityProvider = new CityProvider();
                List<City> cityList = cityProvider.cities;
                ddlCity.DataSource = cityList;
                ddlCity.DataTextField = "Name";
                ddlCity.DataValueField = "CityId";
                ddlCity.DataBind();
                ListItem itemAll = new ListItem();
                itemAll.Text = "All";
                itemAll.Value = "0";
                ddlCity.Items.Insert(0, itemAll);
                gvStudent.DataSource = new StudentProvider().Students;
                gvStudent.DataBind();
            }
        }
        /*private void BindGridViewByGender(char gender)
        {
            List<Student> students = new List<Student>();
            foreach (Student s in new StudentProvider().Students)
            {
                if (s.Gender == gender)
                {
                    students.Add(s);
                }
                gvStudent.DataSource = students;
                gvStudent.DataBind();
            }
        }*/
        protected void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked)
            {
                //lblSelectedGender.Text = "Male Selected";
                //BindGridViewByGender('M');
                gvStudent.DataSource = new StudentProvider().SearchByGender('M');
                gvStudent.DataBind();
            }
        }

        protected void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemale.Checked)
            {
                //lblSelectedGender.Text = "Female Selected";
                //BindGridViewByGender('F');
                gvStudent.DataSource = new StudentProvider().SearchByGender('F');
                gvStudent.DataBind();
            }
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {

        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*lblSelectedGender.Text = ddlCity.SelectedItem.Text;
            int cityId = Convert.ToInt32(ddlCity.SelectedItem.Value);
            List<Student> students = new List<Student>();
            foreach (Student s in new StudentProvider().Students)
            {
                if (s.CityId == cityId) 
                { 
                    students.Add(s); 
                }
            }
            gvStudent.DataSource = students;
            gvStudent.DataBind();*/
            int cityId = Convert.ToInt32(ddlCity.SelectedValue);
            if(cityId == 0)
            {
                gvStudent.DataSource = new StudentProvider().Students;
            }
            else
            {
                gvStudent.DataSource = new StudentProvider().SearchByCity(cityId);
            }
            gvStudent.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string hobbies = string.Empty;

            if(chkMusic.Checked) { hobbies = "Music"; }

            if (chkReading.Checked) { hobbies += "Reading"; }

            if (chkSwimming.Checked) { hobbies += "Swimming"; }

            if (chkSports.Checked) { hobbies += "Sports"; }

            if(hobbies != string.Empty)
            {
                gvStudent.DataSource = new StudentProvider().SearchByHobbies(hobbies);
                gvStudent.DataBind();
            }
        }
    }
}