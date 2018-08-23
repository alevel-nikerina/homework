using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLogic
{
	public class LinkedList : ILinkedList
	{
		public Node Head { get ; set ; }
		public Node Tail { get ; set ; }
		public Node CurrentNode { get ; set ; }
		
		int nodeCandidateValue; // тут должно быть рандомное число или вводить из консоли

		public void Add(Node node)
		{
			if (Head == null)
				Head = new Node(nodeCandidateValue);

			else if (Head != null && Tail == null)
				Tail = new Node(nodeCandidateValue);

			else if (Head != null && Tail != null)
			{
				CurrentNode = Tail;
				Tail = new Node(nodeCandidateValue);
			}

			//else if (Head != null && CurrentNode != null && Tail != null)
			//{
			//	numbers.Remove(nodeCandidateValue);
			//}
		}

		public void OutputAllNodes()
		{
			foreach (var item in numbers)
			{
				Console.WriteLine(item);
			}
		}

		public void Remove(int value)
		{
			if (Head != null && CurrentNode != null && Tail != null)
				{
					Head = CurrentNode;
					CurrentNode = Tail;
					Tail = new Node(value);
				}
		}

		LinkedList<Node> numbers = new LinkedList<Node>();
		
	}
}
