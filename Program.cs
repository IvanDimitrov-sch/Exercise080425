namespace Exercise080425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> files = new HashSet<string>();
            Queue<string> queue = new Queue<string>();
            string file;
            for(int i = 0; i < n; i++)
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
            foreach(string k in queue)
            {
                Console.WriteLine(k);
            }
            
        }
    }
}
