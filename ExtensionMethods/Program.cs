namespace ExtensionMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // Extension Methos DateTimeExtensions
            DateTime dt = new DateTime(2024, 01, 10, 16, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            // Extension Methos StringExtensions
            string s1 = "Bom dia, pessoal!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}