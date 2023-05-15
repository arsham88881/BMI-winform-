using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_winform_
{
    public partial class BMI_calculator : Form
    {
        public BMI_calculator()
        {
            InitializeComponent();
        }
        double height, weight,result;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            height = Convert.ToDouble(txtboxRighter.Text);
            weight = Convert.ToDouble(txtLefter.Text);
            if (height < 3)
            {
                result = weight / Math.Pow(height, 2);
            }
            else
            {
                height = height / 100;
                result = weight / Math.Pow(height,2);
            }
            lblResult.Text = result.ToString();
        }
    }
}
