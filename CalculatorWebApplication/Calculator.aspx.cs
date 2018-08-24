using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMathLibrary;

namespace WebApplication1
{
    

    public partial class Calculator : System.Web.UI.Page
    {
        Class1 MyMath = new Class1();
        double FirstNum;
        double SecondNum;
        double Results;
        

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(TextBox1.Text);
            SecondNum = Convert.ToDouble(TextBox2.Text);           
            Results = MyMath.Addition(FirstNum, SecondNum);
            TextBox3.Text = Results.ToString();
        }

        protected void SubBtn_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(TextBox1.Text);
            SecondNum = Convert.ToDouble(TextBox2.Text);

            Results = MyMath.subtraction(FirstNum, SecondNum);

            TextBox3.Text = Results.ToString();
        }

        protected void MulBtn_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(TextBox1.Text);
            SecondNum = Convert.ToDouble(TextBox2.Text);

            Results = MyMath.multiplication(FirstNum, SecondNum);

            TextBox3.Text = Results.ToString();
        }

        protected void DivBtn_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(TextBox1.Text);
            SecondNum = Convert.ToDouble(TextBox2.Text);

            Results = MyMath.division(FirstNum, SecondNum);

            TextBox3.Text = Results.ToString();
        }

       
    }
}