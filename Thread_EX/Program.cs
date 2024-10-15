namespace Thread_EX
{
    class Program
    {
        static void func()
        {
            int i = 0;
            while (true)
            {
                Console.Write($"{i++} ");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(func));
            thread.IsBackground = true;
            thread.Start();
            Console.WriteLine("Main 종료");
        }
    }
}
