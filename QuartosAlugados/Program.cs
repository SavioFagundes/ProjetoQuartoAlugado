namespace QuartosAlugados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented ?");
            int n = int.Parse(Console.ReadLine());
            Informacion[] vect = new Informacion[n];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Rent #"+i + ":");
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Room:");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Informacion(name, email);

            }
            for (int i = 0; i <= n; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }
            }
        }
    }
}