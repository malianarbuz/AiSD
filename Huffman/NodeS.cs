using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    internal class NodeS:Node
    {
        public char symbol;

        public NodeS(char symbol)
        {  
            this.symbol = symbol;
            this.data = 1;
        }
        
    }
}
