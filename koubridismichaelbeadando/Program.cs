namespace koubridismichaelbeadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HybridData hybridData = new HybridData();

            for (int i = 0; i < 20; i++)
            {
                hybridData.Add($"Key{i}", $"Value{i}");
            }

            Console.WriteLine("Néhány érték kulcshivatkozással:");
            Console.WriteLine(hybridData.Get("Key1"));
            Console.WriteLine(hybridData.Get("Key19"));

            Console.WriteLine("A Key5-t létezik-e: " + hybridData.Contains("Key5"));

            hybridData.Remove("Key5");
            Console.WriteLine("Key5 törölve");
            hybridData.Remove("Key10");

            try
            {
                Console.WriteLine(hybridData.Get("Key5"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Törlés utáni elemszám: {hybridData.Count()}");

            Console.WriteLine("Össz. kulcs listázása:");
            foreach (var key in hybridData.GetAllKeys())
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Key3-ig listázott kulcsok:");
            foreach (var key in hybridData.GetKeysUntil("Key3"))
            {
                Console.WriteLine(key);
            }

            hybridData.Clear();

            Console.WriteLine($"Elemszám törlés után: {hybridData.Count()}");

            Console.ReadLine();
        }
    }
}