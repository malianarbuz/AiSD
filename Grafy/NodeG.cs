using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class NodeG
    {
        List<NodeG> neighbours=new List<NodeG>();
        int data;

        public NodeG(int data)
        {
            this.data = data;
        }
    }
}
