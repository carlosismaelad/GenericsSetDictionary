namespace IntroGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            PrintService<int> pService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                pService.AddValue(x);
            }
            
            pService.Print();
            Console.WriteLine("First: " + pService.Firts());
            
        }
    }
}
