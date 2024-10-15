namespace Thread_EX
{
    class Program
    {
        static void ThreadProc()
        {
            Console.WriteLine($"스레드 ID{Thread.CurrentThread.GetHashCode()}");
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(ThreadProc);

            thread.Start();
            Console.WriteLine($"메인 스레드 ID{Thread.CurrentThread.GetHashCode()}");
        }
    }
}