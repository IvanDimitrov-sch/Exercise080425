using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise080425
{
    internal class Inbox
    {
        public Queue<Message> messages = new();
        HashSet<string> blocked = new();

        public Inbox() { }
        public void AddMessage(Message message)
        {
            messages.Enqueue(message);
        }
        public void AddBlocked(string name)
        {
            blocked.Add(name);
        }
        public void Show()
        {
            foreach (Message m in messages)
            {
                if (!blocked.Contains(m.Name))
                {
                    Console.WriteLine($"From: {m.Name} - {m.Comment}");
                }
            }

        }
    }
}
