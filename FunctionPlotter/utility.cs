using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPlotter
{
    public static class utility
    {
       public static StreamWriter scanner_writer = new StreamWriter("Scanner.txt", false);
       public static StreamWriter tree_writer = new StreamWriter("tree.txt", false);

        public static void closeScannerfile()
        {
            scanner_writer.Close();
        }

        public static void closeTreefile()
        {
            tree_writer.Close();
        }

        static int indentno = 0;

        static void indent()
        {
            indentno += 2;
        }

        static void unindent()
        {
            indentno -= 2;
        }

        static void printspaces()
        {
            for (int i = 0; i < indentno; i++)
            {
                tree_writer.Write(" ");
            }
            
        }

        public static void printTree(treeNode tree)
        {
            indent();

            while (tree != null)
            {
                printspaces();
                tree_writer.WriteLine(tree.tokentype.ToString() + " , " + tree.tokenvalue);

                for (int i = 0; i < tree.child.Length; i++)
                {
                    printTree(tree.child[i]);
                }
                tree = tree.sibling;
            }

            unindent();
        }


    }
}
