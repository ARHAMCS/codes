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


    
    public partial class addwebpage : Form
    {
   
        public  addwebpage()
        {
            InitializeComponent();

        }


        public class stack_node
        {
            public string name;
            public stack_node next;
        }

        public class stack
        {
            public stack_node top = null;
            public void push(string webname)



            {


                StreamWriter stackans = File.AppendText("stactval.txt");
                stack_node newnode = new stack_node();
                newnode.name = webname;
                newnode.next = top;

                stackans.WriteLine(newnode.name);
                top = newnode;
                stackans.Close();
            }
            public void pop()
            {
                if (top == null)
                {

                    MessageBox.Show("stack is empty now");
                    return;
                }
                else
                {

                    MessageBox.Show(top.name);
                    int a;

                    int sum = 0;
                    for (int i=0;i<top.name.Length;i++)
                    {
                        sum = sum + Convert.ToInt32(top.name[i]);
                    }
                   
                    // pushing webpage into stack 
                //   global5.yo.push(top.name);

                    if (addwebpage.global.obj.Find(global.obj.root,sum) == true)
                    {
                        global.obj.deleteNode(global.obj.root,sum);
                    }
                    else
                    {
                        MessageBox.Show("no data found ");
                    }
                        top = top.next;
                }
            }
            public string pop1()
            {
                if (top == null)
                {

                    MessageBox.Show("stack is empty now");
                    return " ";
                }
                else
                {
                    string val;
                    val = top.name;
                   
                    top = top.next;
                    return val;
                }
            }

        }

        public static class global5
        {
            public static stack yo = new stack();
        }

        public class AVL
        {

            public class node
            {
                public int data;
                public node left;
                public node right;
                public node(int data)
                {
                    this.data = data;
                }
            }
            public node root;

            public AVL()
            {
            }
            public void Add(int data)
            {
                node newItem = new node(data);
                if (root == null)
                {
                    root = newItem;
                }
                else
                {
                    root = RecursiveInsert(root, newItem);
                }
            }
            public node RecursiveInsert(node current, node n)
            {
                if (current == null)
                {
                    current = n;
                    return current;
                }
                else if (n.data < current.data)
                {
                    current.left = RecursiveInsert(current.left, n);
                    current = balance_tree(current);
                }
                else if (n.data > current.data)
                {
                    current.right = RecursiveInsert(current.right, n);
                    current = balance_tree(current);
                }
                return current;
            }

            public static node Find(int target, node current)
            {
                while (current == null)
                {
                    MessageBox.Show("no such value found ");
                    break;
                }
                while (current != null)
                {
                    if (target < current.data)
                    {
                        if (target == current.data)
                        {
                            return current;
                        }
                        else
                            return Find(target, current.left);
                    }
                    else
                    {
                        if (target == current.data)
                        {
                            return current;
                        }
                        else
                            return Find(target, current.right);
                    }
                }
                return current;
            }
            public node balance_tree(node current)
            {
                int b_factor = balance_factor(current);
                if (b_factor > 1)
                {
                    if (balance_factor(current.left) > 0)
                    {
                        current = RotateLL(current);
                    }
                    else
                    {
                        current = RotateLR(current);
                    }
                }
                else if (b_factor < -1)
                {
                    if (balance_factor(current.right) > 0)
                    {
                        current = RotateRL(current);
                    }
                    else
                    {
                        current = RotateRR(current);
                    }
                }
                return current;
            }
            public int max(int l, int r)
            {
                return l > r ? l : r;
            }

            public int getHeight(node current)
            {
                int height = 0;
                if (current != null)
                {
                    int l = getHeight(current.left);
                    int r = getHeight(current.right);
                    int m = max(l, r);
                    height = m + 1;
                }
                return height;
            }
            public int balance_factor(node current)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int b_factor = l - r;
                return b_factor;
            }
            public node RotateRR(node parent)
            {
                node pivot = parent.right;
                parent.right = pivot.left;
                pivot.left = parent;
                return pivot;
            }
            public node RotateLL(node parent)
            {
                node pivot = parent.left;
                parent.left = pivot.right;
                pivot.right = parent;
                return pivot;
            }
            public node RotateLR(node parent)
            {
                node pivot = parent.left;
                parent.left = RotateRR(pivot);
                return RotateLL(parent);
            }
            public node RotateRL(node parent)
            {
                node pivot = parent.right;
                parent.right = RotateLL(pivot);
                return RotateRR(parent);
            }
            //public int Find(int key)
            //{


            //    if (root.data == null)
            //    {
            //        return 0;
            //    }
            //    if (root == null)
            //    {
            //        return 0;
            //    }

            //    if (root != null)
            //    {




            //        if (Find(key, root).data == key)
            //        {
            //            MessageBox.Show("found");
            //            return 1;

            //        }

            //    }
            //    else
            //    {

            //        MessageBox.Show("not found");
            //        return 0;
            //    }

            //    return 0;
            //}
            private node findSmallest(node r)
            {
                if (r == null)
                {
                    return null;
                }
                if (r.left != null)
                {
                    r = findSmallest(r.left);
                }
                else
                {
                    return r;
                }
                return r;
            }
            private node findLargest(node r)
            {
                if (r == null)
                {
                    return null;
                }
                if (r.right != null)
                {
                    r = findLargest(r.right);
                }
                else
                {
                    return r;
                }
                return r;
            }

            public bool b = false;
            public bool Find(node root, int key)
            {
                  if (root==null)
                {
                    b = false;
                }

                if (root != null)
                {
                    if (root.data == key)
                    {
                       b = true;
                    }
               
                    else if (root.data < key)
                    {
                        Find(root.right, key);
                    }
                    else
                    {
                        Find(root.left, key);
                    }
                }
                return b ;
            }
        

        public node deleteNode(node r, int n)
            {
                if (r == null)
                {
                    Console.Write("Given Node cannot be found");
                    Console.Write("\n");
                    return null;
                }
                int temp;
                if (n == r.data)
                {
                    if (r.left == null && r.right == null)
                    {
                        MessageBox.Show("webpage deleted ! ");
                        r = null;
                        r = null;
                        return null;
                    }
                    if (r.right != null)
                    {
                        node small = findSmallest(r.right);
                        temp = small.data;
                        small.data = r.data;
                        r.data = temp;
                        r.right = deleteNode(r.right, small.data);
                    }
                    else if (r.left != null)
                    {
                        node large = findLargest(r.left);
                        temp = large.data;
                        large.data = r.data;
                        r.data = temp;
                        r.left = deleteNode(r.left, large.data);
                    }
                }
                else if (n > r.data)
                {
                    r.right = deleteNode(r.right, n);
                    r = balance_tree(r);
                }
                else if (n < r.data)
                {
                    r.left = deleteNode(r.left, n);
                    r = balance_tree(r);
                }
                return r;
            }


        }
        public static class global
        {
            public static AVL obj = new AVL();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String temp;
            temp = textBox1.Text;

            StreamWriter write = new StreamWriter("webpagesnames.txt", true);
            write.WriteLine(temp); //  name of one webpage

            MessageBox.Show("WEB PAGE ADDED SUCCESSFULLY ");




            write.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }
        
        private void button4_Click(object sender, EventArgs e)
        {


            addsubpage obj6 = new addsubpage();
            obj6.ShowDialog();
            //Form4 objk = new Form4();
            //objk.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string a;
            string b;
            a = textBox3.Text;
            a = a + ".txt";
            StreamWriter write = File.AppendText(a) ;

            b = textBox2.Text;

            write.WriteLine(b);

            write.Close();

            MessageBox.Show("KEYWORD ADDED");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    public void button6_Click(object sender, EventArgs e)
        {

            

 
            String a;
            a = textBox3.Text;

            

            int lengofname = a.Length;

            int sum=0;
            for (int i=0;i<lengofname;i++)
            {
                sum=sum+a[i];
            }
            int temp =Convert.ToInt32(sum);


            global.obj.Add(temp);
            global5.yo.push(a);


            MessageBox.Show("added");

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu obj = new menu();
            obj.ShowDialog();
        }
    }
}
