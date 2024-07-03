using System;
using System.Windows.Forms;

namespace DVDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simpleCaluc1.Visible = false;
            //simpleCaluc1.Visible = false;

            //MessageBox.Show(simpleCaluc1.Result.ToString());
        }

        private void simpleCaluc3_Load(object sender, EventArgs e)
        {

        }

        private void BtnSendDate_Click(object sender, EventArgs e)
        {
            //int PersonID = -1;

            //if(int.TryParse(textBox1.Text, out PersonID))
            //{
            //    Form form = new Form2(PersonID);
            //    form.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("PersonID should ba a number!");
            //    textBox1.Focus();
            //}
        }

        private void BtnSendName_Click(object sender, EventArgs e)
        {
            //Form form = new Form2(TBForName.Text);
            //form.ShowDialog();
        }

        private void BtnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.DataBack += Form2_DataBack;
            form.ShowDialog();
        }

        private void Form2_DataBack(object sender, int PersonID)
        {
            //TBResultFromForm2.Text = PersonID.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleCaluc1_OnCalculationComplete(int obj)
        {
            int result = obj;
            MessageBox.Show("Result = " + obj);
        }

        private void simpleCaluc1_Load(object sender, EventArgs e)
        {

        }

        private Form3 form = new Form3();

        private void button1_Click_1(object sender, EventArgs e)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find Clinet is here");
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add new client is here");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exokjd dlk");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        private void TSMChangeFont_Click(object sender, EventArgs e)
        {
        }

        private void simpleCaluc1_Load_1(object sender, EventArgs e)
        {

        }

        private void simpleCaluc1_OnCalculationComplete_1(int obj)
        {

        }
    }
}
