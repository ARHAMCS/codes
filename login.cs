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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                 }

        private void button1_Click(object sender, EventArgs e)
        {
            // obj for reading the intials 
            //StreamWriter obj2 = new StreamWriter("login.txt");
            //obj2.WriteLine("arham");
            //obj2.WriteLine("arham123");
            //obj2.Close();
            StreamReader obj1 = new StreamReader("registration.txt");
            String user_name;
            String password;
            String a;
            String b;


            a = textBox1.Text;
            b = textBox2.Text;

            int counter = 0;
            while (!obj1.EndOfStream)
            {
                user_name = obj1.ReadLine();
                password = obj1.ReadLine();
                if (a == user_name && b == password)
                {
                    MessageBox.Show("LOGIN SUCCESSFUL ! ");
                    counter++;
                    this.Hide();
                    menu obj = new menu();
                    obj.ShowDialog();
                }

            }


            if (counter == 0)
            {
                MessageBox.Show("LOGIN FAILED TRY AGAIN ! ");

            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
