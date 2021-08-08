using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_project.V1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String a;
            a = textBox3.Text;
            char g = a[0];


            int temp = Convert.ToInt32(g);

       //     AVL obj5 = new AVL();

           // obj5.Add(temp);
        }
    }
}
