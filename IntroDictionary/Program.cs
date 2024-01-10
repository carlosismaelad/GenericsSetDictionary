namespace IntroDictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "87654321"; // sobrescreve o valor porque não aceita repetições

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]); // => 87654321

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key.");
            }

            Console.WriteLine("Size: " + cookies.Count); // => tamanho 2 porque removemos uma chave

            Console.WriteLine("All cookies: ");
            foreach (var cookie in cookies) // usamos 'var' em vez de 'KeyValuePair<string, string>' porque o C# faz inferência de tipos
            {
                Console.WriteLine(cookie.Key + " : " + cookie.Value);
                // ou posso fazer Console.WriteLine(cookie);
            }

        }
    }
}