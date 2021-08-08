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
    public partial class addsubpage : Form
    {
        public addsubpage()
        {
            InitializeComponent();
        }

        public class AdjListNode
        {
            public int dest;
            public AdjListNode next;
        }

       
        public class AdjList
        {
            public AdjListNode head;
        }

        
        public class graph
        {
         public  int counter = 0;
            private int V;
            private AdjList[] array;
            public graph(int V)
            {
                this.V = V;
                array = Arrays.InitializeWithDefaultInstances<AdjList>(V);
                for (int i = 0; i < V; ++i)
                {
                    array[i].head = null;
                }
            }
            
            public AdjListNode newAdjListNode(int dest)
            {
                AdjListNode newNode = new AdjListNode();
                newNode.dest = dest;
                newNode.next = null;
                return newNode;
            }
            public void addEdge(int src, int dest)
            {
                AdjListNode newNode = newAdjListNode(dest);
                newNode.next = array[src].head;
                array[src].head = newNode;
               
            }
            public void printGraph()
            {
                StreamWriter write = new StreamWriter("graphy.txt");

                int v;
                for (v = 0; v < V; ++v)
                {
                    AdjListNode pCrawl = array[v].head;
                    write.Write(v);
                    while (pCrawl != null)
                    {
                        write.Write("-> ");
                        write.WriteLine(pCrawl.dest);
                        pCrawl = pCrawl.next;
                    }
                    
                }
                write.Close();
            }
        }



        public static class global1  {


          public static graph obj1 = new graph(200);
            
            }


        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == null)
            {
                MessageBox.Show("cant be empty");
            }
            else
            {
                String a;

                a = textBox1.Text;


                StreamWriter write = File.AppendText(a);


                string b;
                b = textBox3.Text;

                write.WriteLine(b);


                write.Close();

                int lengofname = a.Length;

                int sum = 0;
                for (int i = 0; i < lengofname; i++)
                {
                    sum = sum + a[i];
                }
                int temp = Convert.ToInt32(sum);


                if (addwebpage.global.obj.Find(addwebpage.global.obj.root, temp) == true)
                {
                    global1.obj1.counter = global1.obj1.counter + 1;

                    MessageBox.Show(a);




                }
                else
                    MessageBox.Show("no such website exists");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
            {
                MessageBox.Show("cant be empty");
            }

            else
            {
                if (global1.obj1.counter == 0)
                {
                    MessageBox.Show("first have a webpage to link ! ");
                }
                else
                {
                    string t1;

                    t1 = textBox1.Text;
                    t1 = t1 + ".txt";
                    StreamWriter write = File.AppendText(t1);
                    StreamWriter write1 = File.AppendText("pageandid.txt");
                    string a;
                    a = textBox2.Text;
                    write.WriteLine(a);
                    int t = a.Length;
                    int sum = 0;
                    int b = Convert.ToInt32(a[4]);

                    //1 source -> (97) -> (98)
                    // 2 amazon ->  
                    // graph course vertex = 0 // list -> (97) 
                    global1.obj1.addEdge(global1.obj1.counter, b);
                    global1.obj1.printGraph();
                    write1.WriteLine(global1.obj1.counter);
                    write1.WriteLine(textBox1.Text);
                    //  global1.obj1.printGraph();
                    write.Close();
                    write1.Close();
                    MessageBox.Show("success");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (global1.obj1.counter == 0)
            {
                MessageBox.Show("first have a webpage to link ! ");
            }
            else
            {
                string a;
                a = textBox1.Text;
                a = a + ".txt";

                StreamWriter write = File.AppendText(a);
                string b;
                b = textBox3.Text;

                write.WriteLine(b);

                write.Close();

                MessageBox.Show("success");
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_page obj = new view_page();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu obj = new menu();
            obj.ShowDialog();
        }
    }
    internal static class Arrays
    {
        public static T[] InitializeWithDefaultInstances<T>(int length) where T : new()
        {
            T[] array = new T[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = new T();
            }
            return array;
        }

        public static void DeleteArray<T>(T[] array) where T : System.IDisposable
        {
            foreach (T element in array)
            {
                if (element != null)
                    element.Dispose();
            }
        }
    }
}
