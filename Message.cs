using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise080425
{
    internal class Message
    {
        public string Comment { get; set; }
        public string Name { get; set; }
        public Message(string message, string name)
        {
            Comment = message;
            Name = name;
        }
        
    }
}
