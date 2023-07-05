namespace DesignPattern.CreationalPattern.Singleton
{
    public class SingletonPattern
    {
        private static object obj = new object();
        private static SingletonPattern? instance;
        private SingletonPattern() { }
        public static SingletonPattern getInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new SingletonPattern();
                    }
                }
            }
            return instance;
        }
        public void Display()
        {
            Console.WriteLine("Singleton displaying!");
        }
    }
}