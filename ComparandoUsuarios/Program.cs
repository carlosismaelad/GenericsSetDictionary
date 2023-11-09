using ComparandoUsuarios.Entities;

namespace ComparandoUsuarios
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Client a = new Client { Name = "Maria Isabel", Email = "maria@mail.com" };
            Client b = new Client { Name = "Ana Maria", Email = "maria@mail.com" };

            Console.WriteLine(a.Equals(b)); // True porque usamos o "Email"
            Console.WriteLine(a == b); //compara a referência do ponteiro de memória do objeto
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());


        }
    }
}
