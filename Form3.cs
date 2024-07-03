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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtPersonID.Clear();
        }

        private void TSMChangeColor_Click(object sender, EventArgs e)
        {

        }

        private void TSMChangeFont_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.DataBack += Form_DataBack;

            form.ShowDialog();
        }

        private void Form_DataBack(object sender, int PersonID)
        {
            txtPersonID.Text = PersonID.ToString();
        }
    }
}
