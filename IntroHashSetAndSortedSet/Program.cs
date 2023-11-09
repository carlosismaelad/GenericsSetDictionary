namespace IntroHashSetAndSortedSet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            HashSet<string> set = new HashSet<string>();

            set.Add("Aragorn");
            set.Add("Legolas");
            set.Add("Gandalf");

            Console.WriteLine(set.Contains("Frodo")); // False



            // Para imprimir os elementos usamos o "foreach" e não o "for" porque
            // o conjunto não tem a ideia de posição ([i]);
            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("-----SortedSet-----");

            SortedSet<int> sortedA = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8 };
            SortedSet<int> sortedB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(sortedA);


            // União entre conjuntos
            // Instanciamos um novo conjunto sortedC já inserindo nele todos os elementos
            // de sortedA
            SortedSet<int> sortedC = new SortedSet<int>(sortedA);
            sortedC.UnionWith(sortedB);
            // Inserimos dentro de sortedC todos os elementos de sortedB que já
            // não estejam em sortedC
            PrintCollection(sortedC);

            Console.WriteLine();
            Console.WriteLine("-----Intercessão-----");
            SortedSet<int> SortedD = new SortedSet<int>(sortedA);
            SortedD.IntersectWith(sortedB);
            PrintCollection(SortedD); // retorna o que é comum aos dois conjuntos

            Console.WriteLine();
            Console.WriteLine("-----Diferença-----");
            SortedSet<int> sortedE = new SortedSet<int>(sortedA);
            sortedE.ExceptWith(sortedB);
            PrintCollection(sortedE);
            // retorna os elementos de sortedA excluídos os que haviam em sortedB

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

        }
    }
}
