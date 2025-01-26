using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Grafy
{
    internal class Graf1
    {
        public List<NodeG1> nodes;
        public List<Edge> edges;
        
        public Graf1()
        {
            this.nodes = new List<NodeG1>();
            this.edges = new List<Edge>();
        }
        public void AddNode(NodeG1 node)
        {
            this.nodes.Add(node);
        }
        
        public void AddEdge(Edge e)
        {
            List<NodeG1> n1 = this.nodes.Where(n => n.data == e.start.data).ToList();
            if (n1.Count > 0)
                e.start=n1.First();
            else
                this.AddNode(e.start);

            List<NodeG1> n2 = this.nodes.Where(n => n.data == e.end.data).ToList();
            if (n2.Count > 0)
                e.end = n2.First();
            else
                this.AddNode(e.end);

            this.edges.Add(e);
        }
        public Graf1 DrzewoRozpinajace()
        {
            List<Edge> edges = this.edges.OrderByDescending(e => e.weight).ToList();
            List<Graf1> listaGrafow = new List<Graf1>();
            foreach (NodeG1 node in this.nodes)
            {
                Graf1 a = new Graf1();
                a.AddNode(node);
                listaGrafow.Add(a);              
            }
                foreach(Edge e in edges)
                {
                    Graf1 g1 = listaGrafow.Where(g => g.nodes.Contains(e.start)).ToList().First();
                    Graf1 g2 = listaGrafow.Where(g => g.nodes.Contains(e.end)).ToList().First();
                    if (g1 != g2)
                    {
                        g1.LaczenieGrafow(g2, e);
                        listaGrafow.Remove(g2);
                    if (listaGrafow.Count == 1)
                        break;
                    }
                }        
            return listaGrafow.First();
        }

        private void LaczenieGrafow(Graf1 g2,Edge e)
        {
            this.nodes.AddRange(g2.nodes);
            this.edges.AddRange(g2.edges);
            this.edges.Add(e);            
        }

        public NodeG1 GetNode(int data)
        {
            foreach(NodeG1 node in this.nodes)
            { if(node.data == data) return node;}
            return null;
        }
        public List<Edge> DijkstryAlgorithm(NodeG1 start)
        {
            List<Edge> dijkstryTable = this.CreateDijkstryTable(start);
            int i = 1;
            Edge currentElement = dijkstryTable.Where(e => e.start == start).First();
            currentElement.end = new NodeG1(-1);
            List<NodeG1> visitedNodes = new List<NodeG1>();
            while (i < nodes.Count)
            {
                var toVisit = edges.Where(k => k.start == currentElement.start &&
                !visitedNodes.Contains(k.end)).ToList();
                foreach (Edge k in toVisit)
                {
                    Edge element = dijkstryTable.Where(e => e.start == k.end).First();
                    if (element.weight > currentElement.weight + k.weight)
                    {
                        element.weight = currentElement.weight + k.weight;
                        element.end = currentElement.start;
                    }
                }
                visitedNodes.Add(currentElement.start);
                var elementy = dijkstryTable.Where(e => !visitedNodes.Contains(e.start)).ToList();
                currentElement = elementy.OrderBy(e => e.weight).First();
                i++;
            }
            return dijkstryTable;
        }
        public List<Edge> CreateDijkstryTable(NodeG1 start)
        {
            List<Edge> list = new List<Edge>();
            foreach (NodeG1 node in nodes)
            {
                if (node != start)
                    list.Add(new Edge(node, null, int.MaxValue));
                else
                    list.Add(new Edge(node, null, 0));
            }
            return list;
        }
        override
        public String ToString()
        {
            String results = "Nodes: \n";
            foreach(NodeG1 node in this.nodes)
                results += node.ToString()+" ";
            results += "\nEdges: \n";
            foreach(Edge e in this.edges)
                results += e.ToString()+" ";
            return results;
        }

    }
    
}
