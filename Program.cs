namespace xddd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int result = suma(2, 3);

            string nombrecompleto = nombre("Nelson", "Garcia");
            
        }
        public static int suma(int n1, int n2)
        {
            return n1+ n2;
        }
        public static string nombre(string name, string lastname)
        {
            return name + lastname;
        }
    }
}