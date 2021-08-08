using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace data_project.V1
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            StreamWriter obj1 = new StreamWriter("registration.txt");
            String a;
            String b;

            a = textBox1.Text;
            b = textBox2.Text;

            obj1.WriteLine(a);
            obj1.WriteLine(b);


            obj1.Close();

            MessageBox.Show("REGISTRATION SUCESSFUL ! ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login okay = new login();
            this.Hide();
            okay.ShowDialog();
        }
    }
}
