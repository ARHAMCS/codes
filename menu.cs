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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addwebpage OBJ = new addwebpage();
            this.Hide();
            OBJ.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_page obj = new view_page();
            this.Hide();
            obj.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            search obj = new search();

            obj.ShowDialog();





        }
    }
}
