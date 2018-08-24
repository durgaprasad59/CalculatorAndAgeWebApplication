using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class AgeCalculator : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Subbtn_Click(object sender, EventArgs e)
        {
            int NumberofMonths;
            int NumberofDays;
            int NumberofYears;

            DateTime date = new DateTime();
            date = DateTime.Now;
            int Ageday = Convert.ToInt16(TextBox1.Text.Substring(0, 2));
            int Agemm = Convert.ToInt16(TextBox1.Text.Substring(2, 2));
            int Ageyy = Convert.ToInt16(TextBox1.Text.Substring(4, 4));

            

            NumberofYears = date.Year - Ageyy;

            //if (date.Month > Agemm)
            //{
            //    NumberofMonths = date.Month - Agemm;
            //}
            //else if (date.Month < Agemm)
            //{
            //    NumberofMonths = (12 - Agemm) + date.Month;
            //    //NumberofYears = NumberofYears - 1;
            //}

            //if (date.Day > Ageday)
            //{
            //    NumberofDays = date.Day - Ageday;
            //}
            //else if (date.Day < Ageday)
            //{
            //    NumberofDays = 31 - Ageday + date.Day;
            //    //NumberofMonths = NumberofMonths - 1;
            //}
            

            GenLab.Text = DropDownList1.Text;
            AgeLab.Text = NumberofYears.ToString();

        }
    }
}