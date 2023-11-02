namespace IntroGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            PrintService pService = new PrintService();

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
