using System.Runtime.Intrinsics.Arm;
using ExerConjuntoLogUsuarios.Entities;

namespace ExerConjuntoLogUsuarios
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { UserName = name, Instant = instant });
                    }
                    Console.WriteLine("Total user: " + set.Count);
                }
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}