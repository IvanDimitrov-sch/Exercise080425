namespace Exercise080425
{
    internal class Program
    {
        static void Main(string[] args)
        {
             zad1();
            zad2();
        }
        static void zad1()
        {
            Console.WriteLine("Zadacha 1");
            int n = int.Parse(Console.ReadLine());
            HashSet<string> files = new HashSet<string>();
            Queue<string> queue = new Queue<string>();
            string file;
            for (int i = 0; i < n; i++)
            {
                file = Console.ReadLine();
                if (file.Equals(""))
                {
                    break;
                }
                if (files.Contains(file))
                {
                    Console.WriteLine("Repetition");
                }
                else
                {
                    files.Add(file);
                    queue.Enqueue(file);
                }
            }
            Console.WriteLine("Result:\n");
            foreach (string k in queue)
            {
                Console.WriteLine(k);
            }
        }
        static void zad2()
        {
            Console.WriteLine("Zadacha 2");
            int n = int.Parse(Console.ReadLine());


            Inbox inbox = new();
            for(int i = 0; i < n;i++)
            {
                string[] w = Console.ReadLine().Split("|").ToArray();
                Message m = new(w[1], w[0]);

                inbox.AddMessage(m);
            }
            Console.WriteLine("Enter numbers of blocked people");
            int blockedN = int.Parse(Console.ReadLine());
            for(int i = 0; i < blockedN; i++)
            {
                inbox.AddBlocked(Console.ReadLine());
            }
            inbox.Show();
        }
    }
}
