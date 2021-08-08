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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.Default;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("webpagesnames.txt");
            string a;

            view_page.LL obj1 = new view_page.LL();
            addwebpage.stack obj2 = new addwebpage.stack();
            int counter;
            a = textBox2.Text;

            // breaking and storing the searched string 
            string[] breakk = a.Split(' ');
            int k2 = breakk.Length;
            foreach (var word in breakk)
            {
                obj1.insert(word);
            }


            string b = ".";

            while (a != null)
            {
                a = read.ReadLine();
                obj2.push(a);

            }
            string[] k;
            string hold = ".";
            // not equal to null

            while (hold != " ")
            {

                int i = 0;

                hold = obj2.pop1();
                if (hold != null)
                {
                    k = hold.Split('.');


                    if (hold == "")
                    {
                        break;
                    }
                    string g = k[1];

                    string n = hold;
                    g = g + ".txt";
                    try
                    {

                        while (breakk[i] != null)
                        {

                            {
                                StreamReader read1 = new StreamReader(g);

                                while (!read1.EndOfStream)
                                {
                                    if (breakk[i] == read1.ReadLine())
                                    {
                                        MessageBox.Show("WORD FOUND IN WEBPAGE ! ");

                                        MessageBox.Show(n);
                                    }

                                }
                                read1.Close();
                                i++;
                                if (i == k2)
                                {
                                    break;
                                }
                            }


                        }

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("file does not exist");
                    }
            }
            }
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
