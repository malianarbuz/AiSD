using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Graf
    {
        List<NodeG> nodes=new List<NodeG>();

        public void Add(int data)
        {
            NodeG node = new NodeG(data);
            this.nodes.Add(node);
        }
    }
}
