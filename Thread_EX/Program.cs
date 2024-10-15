namespace Thread_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(ThreadProc1));
            th.Start();

            Console.WriteLine($"Main 스레드 : {Thread.CurrentThread.GetHashCode}");
            Console.WriteLine("Main 종료");
        }
        private static void ThreadProc1()
        {
            Console.WriteLine($"ThreadProc1 아이디 : {Thread.CurrentThread.GetHashCode()}");
            Thread thread = new Thread(new ThreadStart(ThreadProc2));
            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i * 10}");
                Thread.Sleep(200);
                if (i == 3)
                {
                    Console.WriteLine("ThreadProc1 종료");
                    Thread.CurrentThread.Abort();
                }
            }
        }
        private static void ThreadProc2()
        {
            Console.WriteLine($"ThreadProc2 아이디 : {Thread.CurrentThread.GetHashCode()}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}");
                Thread.Sleep(200);
            }
            Console.WriteLine("ThreadProc2 종료");
        }
    }
}