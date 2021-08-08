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
    public partial class view_page : Form
    {
        public view_page()
        {
            InitializeComponent();
        }

        public class Node
        {
            public string data;
           // public int countt;
            public Node next;
        }

        public  class LL
        {
            public Node head = null;
            public  void insert(string new_data)
            {
                Node new_node = new Node();
                new_node.data = new_data;
                new_node.next = head;
           //     new_node.countt = data;
                head = new_node;
            }
            public  void mergenodes(string a)
            {
                Node ptr;
                ptr = head;
                while (ptr != null)
                {

}
                    ptr = ptr.next;
                }

            public int countOccurence( string X)
            {
                int count = 0;
                Node temp = head;
                while (temp != null)
                {
                    
                    if (temp.data == X)
                    {
                        count++;
                    }

                    temp = temp.next;
                }

                return count;

          
            }

            public void traverseList()
            {
                Node temp;


                if (head == null)
                {
                   MessageBox.Show("List is empty.");
                    return;
                }

                temp = head;

                
                while (temp != null)
                {
                  temp = temp.next; // Move to next node
                }
            }

        }









        public class BST
        {

            // Class containing left and
            // right child of current node
            // and key value
            public class Node
            {
                public int key;
                public Node left, right;

                public Node(int item)
                {
                    key = item;
                    left = right = null;
                }
            }

            // Root of BST
           public Node root;

            // Constructor
            public BST()
            {
                root = null;
            }

            // This method mainly calls insertRec()
            public void insert(int key)
            {
                root = insertRec(root, key);
               
            }

            // A recursive function to insert
            // a new key in BST
            Node insertRec(Node root, int key)
            {

              
                if (root == null)
                {
                    root = new Node(key);
                    return root;
                }

                if (key < root.key)
                    root.left = insertRec(root.left, key);
                else if (key > root.key)
                    root.right = insertRec(root.right, key);
                StreamWriter write = new StreamWriter("bst.txt");
                write.WriteLine(root.key);
                write.Close();
                // Return the (unchanged) node pointer
                return root;
            }

            // This method mainly calls InorderRec()
            public void inorder()
            {
                inorder1(root);
            }

            // A utility function to
            // do inorder traversal of BST
            public void inorder1(Node root)
            {
                
                if (root != null)
                {
                    inorder1(root.left);
                    
                    inorder1(root.right);
                  
                }
            }
        

            public void show()
            {

            }
           public void traver_bstinorder(Node root, List<int> arr)
            {
                if (root == null)
                {
                    return;
                }

                // first recur on left subtree
                traver_bstinorder(root.left, arr);

                // then copy the data of the node
                arr.Add(root.key);

                // now recur for right subtree
                traver_bstinorder(root.right, arr);
            }

            public void convert(Node root, List<int> arr, ref int i)
            {
                if (root == null)
                {
                    return;
                }
                
              
                convert(root.left, new List<int>(arr), ref i);

                
                convert(root.right, new List<int>(arr), ref i);
                root.key = arr[++i];
            }

            // Utility function to convert the given BST to
            // MAX HEAP
            public void convertToMaxHeapUtil(Node root)
            {
                // vector to store the data of all the
                // nodes of the BST
                List<int> arr = new List<int>();
                int i = -1;

                // inorder traversal to populate 'arr'
                traver_bstinorder(root, arr);

                // BST to MAX HEAP conversion
                convert(root, new List<int>(arr), ref i);
            }

            
        }

        public static class pass
        {

            public static int first_pass = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            pass.first_pass++;
            
            StreamWriter write = File.AppendText("webpageandcount.txt");
            int a1;
            int j;
            string a;
            string llk;
            a = textBox1.Text;
          
            write.WriteLine(a);
            int sum = 0;
            int occ;

            global4.obj4.insert(a);
        
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            a1 = Convert.ToInt32(sum);
            int c = 0;
            a = a + ".txt";
            if (addwebpage.global.obj.Find(addwebpage.global.obj.root, a1) == true)
            {


                StreamReader read = new StreamReader(a);

                while (c < 1)
                {
                    a = read.ReadLine();
                    if (a == null)
                        c++;
                        
                    if (a != null)
                    {
                        if (a[0] == 'w' && a[1] == 'w' && a[2] == 'w')
                        {
                            c++;
                            read.Close();
                        }
                        else
                        {

                            MessageBox.Show(a);
                        }
                    }
                   
                }
            }
            write.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (textBox1.Text==null)
            {
                MessageBox.Show("enter valid credentials");
            }
            if (pass.first_pass != 0)
            {
                int a1;
                int j;
                string temp;
                string a;
                a = textBox1.Text;
                if (a == "")
                {
                    MessageBox.Show("cannot be empty");
                }
                else
                {
                    temp = textBox2.Text;
                    int sum = 0;

                    for (int i = 0; i < a.Length; i++)
                    {
                        sum = sum + a[i];
                    }
                    a1 = Convert.ToInt32(sum);
                    int c = 0;
                    a = a + ".txt";
                    // if (Form3.global.obj.Find(a1) == 1)
                    {
                        StreamReader read = new StreamReader(a);
                        while (temp != a)
                        {

                            a = read.ReadLine();
                        }


                        if (a != null)
                        {
                            while (c < 1)
                            {

                                a = read.ReadLine();
                                if (a==null)
                                {
                                    c++;
                                }
                                if (a != null)
                                {
                                    if (a[0] == 'w' && a[1] == 'w' && a[2] == 'w')
                                    {
                                        c++;
                                        read.Close();
                                    }
                                    else
                                    {

                                        MessageBox.Show(a);
                                        // richTextBox2.Text=(a);

                                    }
                                }
                                
                            }
                            read.Close();
                        }
                        read.Close();
                    
                    }
                    
                }

               
            }
            else
            {
                MessageBox.Show("first perform webpage view");
            }
        }
        public static class global4
        {
            public static LL obj4 = new LL();
            public static int first_pass=0;
        }
        public static class global3
            {
            public static BST obj3 = new BST();
            }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("NO DATA");

            }
            else
            {
                StreamWriter kk = File.AppendText("page and count.txt");

                string a = textBox1.Text;
                int occ;

                kk.WriteLine(a);
                occ = global4.obj4.countOccurence(a);

                global4.obj4.insert(a);
                kk.WriteLine(occ);
                global3.obj3.insert(occ);
                kk.Close();







                //string temp;
                //temp = textBox1.Text;


                //b = read.ReadLine();

                //string k;
                //k = b + ".txt";
                //StreamWriter write1 = new StreamWriter(k);

                //while (b != null)
                //{
                //    while (temp == b)
                //    {
                //        if (b != null)
                //        {
                //            b = read.ReadLine();
                //            c++;
                //        }

                //        write1.WriteLine(temp);

                //        b = read.ReadLine();


                //    }
                //}
                //write1.Close();

                //read.Close();

                //StreamReader read1 = new StreamReader("countandname.txt");

                //string g=".";
                //while (g != null)
                //{
                //    read1.ReadLine();
                //    g = read1.ReadLine();

                //    int g1 = Convert.ToInt32(g);
                //    if (g != null)
                //    {
                //        global3.obj3.insert( g1);

                //    }
                //    else
                //    {
                //        break;
                //    }
                //}
                //read1.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == null)
            {
                MessageBox.Show("NO DATA");

            }
            else
            {
                global3.obj3.convertToMaxHeapUtil(global3.obj3.root);
                int t;
                StreamReader read = new StreamReader("page and count.txt");
                string a = ".";
                string name;
                while (a != null)
                {
                    name = read.ReadLine();
                    a = read.ReadLine();

                    t = Convert.ToInt32(a);


                    if (t == global3.obj3.root.key)
                    {
                        MessageBox.Show(name);
                        read.ReadLine();
                    }

                }

                read.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            StreamWriter popp = File.AppendText("poppedvals.txt");


            addwebpage.global5.yo.pop();
            popp.Close();
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu obj = new menu();
            obj.ShowDialog();
        }
    }
}
