using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_CollectionNamespace_Lesson18
{
    internal class Node
    {
        internal Message data;
        internal Node next;

        public Node(Message message)
        {
            this.data = message;
        }
    }
}
