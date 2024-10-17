using StandardApplication.BAL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StandardApplication
{
    public partial class EmployeeBonus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string salary = txtSalary.Text.Trim();
            int sal = 0;
            bool error = false;

            if (name == string.Empty)
            {
                lblNameError.Text = "Name Required";
                error = true;
                SetValue();
            }
            else
            {
                lblNameError.Text = "*";
            }
            if (salary == string.Empty)
            {
                lblSalaryError.Text = "Salary Required";
                error = true;
                SetValue();
            }
            else
            {
                sal = Convert.ToInt32(salary);
                if (sal <= 0)
                {
                    lblSalaryError.Text = "Invalid Salary";
                    error = true;
                    SetValue();
                }
                else
                {
                    lblSalaryError.Text = "*";
                }

            }
            if (!error)
            {
                Employee emp = new Employee();
                emp.SetName(name);
                emp.Salary = sal;
                emp.CalculateBonus();
                emp.CalculateNetSalary();
                Tuple<string, int, float, float> result = emp.GetData();
                txtName.Text = result.Item1.ToUpper();
                txtBonus.Text = Convert.ToString(result.Item3);
                txtNetSalary.Text = Convert.ToString(result.Item4);
            }

        }

        private void SetValue()
        {
            txtBonus.Text = string.Empty;
            txtNetSalary.Text = string.Empty;
        }
    }
}