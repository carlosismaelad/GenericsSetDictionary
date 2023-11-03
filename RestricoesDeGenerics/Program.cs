using System.Globalization;
using RestricoesDeGenerics.Entities;
using RestricoesDeGenerics.Services;

namespace RestricoesDeGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            List<Product> list = new List<Product>();

            Console.Write("Quantos elementos terá a lista? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome e preço: ");
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine();
            Console.Write("Max: ");
            Console.WriteLine(max);
        }
    }
}
