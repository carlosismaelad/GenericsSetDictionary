namespace EqualsAndGetHashCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string a = "Maria";
            string b = "Jose";
            string c = "Maria";

            Console.WriteLine("a é igual a b? " + a.Equals(b));
            Console.WriteLine("a é igual a c? " + a.Equals(c));

            Console.WriteLine();
            Console.WriteLine("GetHashCode");
            Console.WriteLine("HashCode de a: " + a.GetHashCode());
            Console.WriteLine("HashCode de b: " + b.GetHashCode());
            Console.WriteLine("HashCode de c: " + c.GetHashCode());

        }
    }

}
