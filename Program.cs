namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(DisplayOne);
            Thread thread2 = new Thread(DisplayTwo);
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }

        public static void DisplayOne()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Console.Write("Runing First Thread: " + i);
                Thread.Sleep(1000);
            }
        }

        public static void DisplayTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Runing Second Thread: " + i);
                Thread.Sleep(1000);
            }
        }
    }
}