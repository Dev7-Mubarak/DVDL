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
    public partial class Form2 : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;

        private int _personID;
        private string _name;

        public Form2(string name)
        {
            InitializeComponent();
            _name = name;
        }

        public Form2(int personID)
        {
            InitializeComponent();
            _personID = personID;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = _personID.ToString();
            LabForName.Text = _name;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void BtnSendDateBack_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(textBox1.Text);

            DataBack?.Invoke(this, PersonID);

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabPersonID_Click(object sender, EventArgs e)
        {

        }
    }
}
