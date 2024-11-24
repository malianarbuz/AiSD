using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class NodeG
    {
        List<NodeG> neighbors;
        public int data;

        public NodeG(int data)
        {
            this.data = data;
        }

        public void AddConnection(NodeG node)
        {
            if(this.neighbors.Contains(node))
                return;
            this.neighbors.Add(node);
            node.neighbors.Add(this);
        }
    }
}
