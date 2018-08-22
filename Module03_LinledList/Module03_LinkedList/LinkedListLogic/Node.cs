using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLogic
{
	public class Node
    {
        public Node Next { get; set; }

        public int Value { get; set; }

		public Node(int value)
		{
			Value = value;
		}
    }
}
