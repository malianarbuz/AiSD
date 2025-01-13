using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Graf1
    {
        public List<NodeG1> nodes;
        public List<Edge> edges;
        
        public void Add(Edge e)
        {
            if (this.nodes == null)
            {
                this.nodes = new List<NodeG1>();
                this.nodes.Add(e.start);
                this.nodes.Add(e.end);
                this.edges = new List<Edge>();
                this.edges.Add(e);
            }
            else if (this.nodes.Contains(e.start) && this.nodes.Contains(e.end) && !this.edges.Contains(e))
            {
                
            }
            else 
            { 
                if(!this.nodes.Contains(e.start))
                    this.nodes.Add(e.start);

                if(!this.nodes.Contains(e.end))
                    this.nodes.Add(e.end);
                this.edges.Add(e);
            }
        }
        public Graf1 DrzewoRozpinajace()
        {
            this.edges = this.edges.OrderByDescending(e => e.weight).ToList();
            Graf1 rozp=new Graf1();
            int i = 1;
            rozp.Add(this.edges[0]);
            while (rozp.nodes.Count() != this.nodes.Count()) 
            {
                rozp.Add(this.edges[i]);
                i++;
            }
            return rozp;
        }
        public List<Edge> Dikstry(NodeG1 start)
        {
            List<Edge> result= new List<Edge>();
            foreach (NodeG1 node in this.nodes)
            {
                Edge e = new Edge(start, node, 2147483647);
                if (node == start)
                    e.weight = 0;
            }

            return result;
        }
            
    }
}
