using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class NodeT
    {
        public NodeT left;
        public NodeT right;
        public NodeT parent;
        public int data;
        public int index;

        public NodeT(int number)
        {
            this.data = number;
        }
    }
}
