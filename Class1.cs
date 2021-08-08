using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_project.V1
{
    public class node
    {
       public int data;
        public node left, right;

        public node ()
        {
            data = 0;
            left=right = null;
        }

        


    }

   

        //public node insert(node head, int d)
        //{
        //    node pointer = new node();
        //    pointer.data = d;
        //    pointer.right = null;
        //    pointer.left = null;


        //    if (root== null)
        //    {
        //        root = pointer;

        //        return head;
        //    }

        //    node s;

        //    if (d < pointer.data)
        //    {
        //        pointer.left = insert(pointer.left, d);
        //    }
        //    if (d > pointer.data)
        //    {
        //        pointer.right = insert(pointer.right, d);
        //    }
        //    return root;
        //}

        //public node getroot()
        //{
        //    return root;
        //}

        


    
}
