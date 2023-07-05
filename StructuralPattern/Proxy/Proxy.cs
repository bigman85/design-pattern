namespace DesignPattern.StructuralPattern.Proxy
{
    public class Proxy : IService
    {
        private Service service;
        public void Method1()
        {
            if (service == null)
            {
                service = new Service();
            }

            service.Method1();
            Console.WriteLine("Method1 run in Proxy");
        }
    }
}