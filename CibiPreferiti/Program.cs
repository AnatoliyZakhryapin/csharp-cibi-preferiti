namespace CibiPreferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array di cibi preferiti
            string[] cibiPreferiti = { "Sushi", "Parmigiana", "Gelato al pistacchio salato", "Lasagna", "Pasta alla carbonara", "Ravioli", "Bistecca alla fiorentina", "Ceviche", "Tiramisù", "Curry di pollo" };

            // Stampiamo la lunghezza del array cibiPreferiti
            Console.WriteLine(cibiPreferiti.Length);

            // Stampiamo la classifica dei cibi preferiti
            Console.WriteLine("Classifica cibi:");
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cibiPreferiti[i]}");
            };

            // Otteniamo il primo elemento dell'array cibiPreferiti
            string ciboPreferito = cibiPreferiti.First();

            // Stampiamo il cibo preferito
            Console.WriteLine($"Il mio cibo preferito è: {ciboPreferito}");

            // Otteniamo il ultimo elemento dell'array cibiPreferiti
            string ciboMenoPreferito = cibiPreferiti.Last();

            // Stampiamo il cibo meno preferito
            Console.WriteLine($"Il mio cibo meno preferito è: {ciboMenoPreferito}");
        }
    }
}
