using Biblio;
namespace Console_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Passager[] passagers = new Passager[]
            {
                new Passager("Noah", 'A', 12),
                new Passager("Liam", 'B', 12),
                new Passager("Edouard", 'C', 11),
                new Passager("Rose", 'F', 12),
                new Passager("Olivia", 'E', 12),
                new Passager("Florence", 'D', 12)
            };



            Avion avion = new Avion("<pilote>", "<copilote>", new string[] { "<agent1>", "<agent2>", "<agent3>" }, passagers);
            Console.WriteLine(avion);
        }
    }
}