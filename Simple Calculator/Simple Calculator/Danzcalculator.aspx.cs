using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simple_Calculator
{
    public partial class Danzcalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
       {
          
        }
        
protected void Value2TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string add = Value1TextBox.Text;
            int a = int.Parse(add);
            string add2 = Value2TextBox.Text;
            int a2 = int.Parse(add2);

            int d = a + a2;
            resultLabel.Text = d.ToString();

        }

        protected void SubtractButton_Click(object sender, EventArgs e)
        {
            string sub = Value1TextBox.Text;
            int s = int.Parse(sub);
            string sub2 = Value2TextBox.Text;
            int s2 = int.Parse(sub2);

            int f = s - s2;
            resultLabel.Text = f.ToString();

        }

        protected void DivisionButton_Click(object sender, EventArgs e)
        {
            string sub = Value1TextBox.Text;
            double s = int.Parse(sub);
            string sub2 = Value2TextBox.Text;
            double s2 = int.Parse(sub2);

            double f = (double)s / (double)s2;
            resultLabel.Text = f.ToString();
        }

        protected void MultiplicationButton_Click(object sender, EventArgs e)
        {
            string sub = Value1TextBox.Text;
            int s = int.Parse(sub);
            string sub2 = Value2TextBox.Text;
            int s2 = int.Parse(sub2);

            int f = s * s2;
            resultLabel.Text = f.ToString();
        }
    }
}
