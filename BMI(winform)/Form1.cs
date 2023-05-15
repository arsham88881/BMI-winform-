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
        string statusshow;
        double height, weight,curBMI;

        private void btnRemach_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.BackColor = Color.White;   
            /*
            foreach (Control n in Controls)
            {
                n.BackColor = Color.White;
                n.Text = "";
            }
            */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult zzz;
            zzz = MessageBox.Show("از خروج خود مطمئن هستید؟", "خروج", MessageBoxButtons.YesNo);
            if(zzz == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        double bestBMIupperband, bestBMIlowwerband;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            height = Convert.ToDouble(txtboxRighter.Text);
            weight = Convert.ToDouble(txtLefter.Text);
            if (height < 3) //this part calculat current user status
            {
                curBMI = weight / Math.Pow(height, 2);
            }
            else
            {
                height = height / 100;
                curBMI = weight / Math.Pow(height,2);
            }
            bestBMIlowwerband = 18.5 * Math.Pow(height, 2);  //
            bestBMIupperband = 24.9 * Math.Pow(height, 2);  //caclulat best range for weight;
            
            Color txtcolor = new Color();
            if (curBMI < 18.5)
            {
                statusshow = "کمبود وزن";
                txtcolor = Color.LightBlue;
            }
            else if(curBMI >= 18.5 && curBMI < 25)
            {
                statusshow = "وزن نرمال";
                txtcolor = Color.LightGreen;
            }
            else if(curBMI >= 25 &&  curBMI < 30)
            {
                statusshow = "اضافه وزن";
                txtcolor = Color.Orange;
            }
            else if(curBMI >= 30 && curBMI < 35)
            {
                statusshow = "چاق";
                txtcolor = Color.Red;
            }
            else if(curBMI >=35 && curBMI < 50)
            {
                statusshow = "خیلی چاق";
                txtcolor = Color.DarkRed;
            }
            else
            {
                statusshow = "خارج از رنج";
                txtcolor = Color.White;
            }
            BackColor = txtcolor; //for applying color

            lblResultupper.Text = "وضعیت فعلی :"+statusshow+"  " ;  //+"best : "+ bestBMIupperband.ToString()+"  "+bestBMIlowwerband.ToString();
            lbllowerr.Text = "محدوده ی وزنی مطلوب : "+Math.Round(bestBMIlowwerband)+" تا "+Math.Round(bestBMIupperband)+" کیلوگرم ";
        }
    }
}
