using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPlotter
{
    public enum ExpKind { OpKind, NumKind, IdKind};
    public class treeNode
    {
        public treeNode[] child;
        public treeNode sibling;
        public ExpKind expkind;
        public TokenType tokentype;
        public string tokenvalue;

        public treeNode()
        {
            child = new treeNode[3];
            sibling = null;
        }

        public treeNode(int num_nodes)
        {
            child = new treeNode[num_nodes];
            sibling = null;
        }

        
    }
}
