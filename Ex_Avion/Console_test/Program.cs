using Biblio;
namespace Console_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Passager[] passagers = new Passager[]
            {
                new Passager("Noah", 'A', 12, new DateTime()),
                new Passager("Liam", 'B', 12, new DateTime()),
                new Passager("Edouard", 'C', 11, new DateTime()),
                new Passager("Rose", 'F', 12, new DateTime()),
                new Passager("Olivia", 'E', 12, new DateTime()),
                new Passager("Florence", 'D', 12, new DateTime()),
                new Passager("Marianne", 'B', 16, new DateTime()),
                new Passager("Félix", 'E', 16, new DateTime()),
            };



            Avion avion = new Avion("<pilote>", "<copilote>", new string[] { "<agent1>", "<agent2>", "<agent3>" }, passagers);
            Console.WriteLine(avion);
            Console.WriteLine(new ListePassagers(avion.Decharcher()));
        }
    }
}