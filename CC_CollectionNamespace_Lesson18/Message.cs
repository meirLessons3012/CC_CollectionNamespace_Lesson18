using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_CollectionNamespace_Lesson18
{
    public class Message
    {
        public string Sender { get; set; }
        public string Text { get; set; }

        public Message(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
