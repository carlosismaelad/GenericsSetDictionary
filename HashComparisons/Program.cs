using HashComparisons.Entities;

namespace HashComparisons
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("Tv", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            // Vamos testar a igualdade ente "prod" e "a"
            // Como usamos o new quer dizer que este será um 
            // outro objeto em memória diferente do instanciado anteriormente.
            Product prod = new Product("Notebook", 1200.0);

            // Na comparação será levado em conta o conteúdo dos objetos ou o endereço de memória?
            Console.WriteLine(a.Contains(prod)); // => False
                                                 // Foi comparado as referências de memória, as referências dos objetos

            // Depois de implementado o GetHashcode e Equal em Product o Console.WriteLine acima retorna True


            // No caso abaixo (struct) mesmo não tendo implementado o GetHashcode e o Equal em Point ele vai retornar True
            // porque ele vai comparar por conteúdo e não por referência
            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point));




        }
    }
}
