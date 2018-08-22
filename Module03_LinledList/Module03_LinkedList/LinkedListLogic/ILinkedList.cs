using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLogic
{
    public interface ILinkedList
    {
        Node Head { get; set; }

        Node Tail { get; set; }

        void Add(Node node);

        void Remove(int value); //in case if there are 2 items with this value         //- remove first

        void OutputAllNodes();
    }

    //реализовать интерфейс для добавления эль-то в список
    //и вывод на экран всех значений которые были добавлены.
}
