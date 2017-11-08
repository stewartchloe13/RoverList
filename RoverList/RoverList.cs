using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here

        public RoverList()
        {
            head = null;
        }

        private int count = 0;
        public override int Count => count;

        public override void Add(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                current = head;
            }
            else
            {
                current.Next = new Node(data);
                current = current.Next;
            }
            count++;

        }

        public override void Add(int Position, object data)
        {
            throw new NotImplementedException();
        }

        public override void Clear()
        {
            head = null;
            count = 0;
        }

        public override Node ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {

            Node last = ElementAt(Position - 1);
            last.Next = last.Next.Next;

            return true;


        }
    }
}
