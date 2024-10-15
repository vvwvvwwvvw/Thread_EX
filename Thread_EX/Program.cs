namespace Thread_EX
{
    class Program
    {
        static void ThreadProc()
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.Write($"{i}");
                Thread.Sleep( 200 );
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(ThreadProc));
            thread.Start();
            thread.Join(); // 위에 부 스레드가 끝날때 까지 메인종료 메세지( 주 스레드 ) 대기시킴
            Console.WriteLine("메인 종료");
        }
    }
}