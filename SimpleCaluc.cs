using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL
{
    public partial class SimpleCaluc : UserControl
    {
        public event Action<int> OnCalculationComplete;

        protected virtual void CalculationComplete(int PersonID)
        {
            Action<int> handler = OnCalculationComplete;
            if(handler != null)
            {
                handler(PersonID);
            }
        }

        public SimpleCaluc()
        {
            InitializeComponent();
        }

        public double Result 
        {
            get { return Convert.ToDouble(labResult.Text); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(maskedTextBox1.Text);
            labResult.Text = result.ToString();

            if (OnCalculationComplete != null)
            {
                CalculationComplete(result);
            }
        }

        private void SimpleCaluc_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labResult_Click(object sender, EventArgs e)
        {

        }

        //private void textBox1_Validating(object sender, CancelEventArgs e)
        //{
        //    if(string.IsNullOrEmpty(textBox1.Text))
        //    {
        //        e.Cancel = true;
        //        textBox1.Focus();
        //        errorProvider1.SetError(textBox1, "FirstName is requerd");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider1.SetError(textBox1, "");
        //    }
        //}
    }
}
