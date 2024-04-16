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

            /*
             *  BONUS
             */

            // Creamo la variabile con la lunghezza dell'array "cibiPreferiti"
            int lengthOfCibiPreferiti = cibiPreferiti.Length;

            // Se lunghezza di cibiPreferiti e un numero pari
            if (lengthOfCibiPreferiti % 2 == 0 ) 
            {
                // Recuperiamo indici dei valori centrali sia quello di sinistra che di destra
                int middleLeftIndex = lengthOfCibiPreferiti / 2 - 1;
                int middleRightIndex = lengthOfCibiPreferiti / 2;

                // Creamo le variabile con i valori centrali dell'array cibiPreferiti
                string middleLeftOfCibiPreferiti = cibiPreferiti[middleLeftIndex]; 
                string middleRightOfCibiPreferiti = cibiPreferiti[middleRightIndex];

                // Stampiamo i valori centrali dell'array cibiPreferiti
                Console.WriteLine($"Middle left Value: {middleLeftOfCibiPreferiti}");
                Console.WriteLine($"Middle Right Value: {middleRightOfCibiPreferiti}");
            } 
            // Nel caso in cui la lunghezza di cibiPreferiti e un numero dispari
            else
            {
                // Recuperiamo indice del valore centrale
                int middleIndex = lengthOfCibiPreferiti / 2;

                // Creamo la variabile con il valore centrale dell'array cibiPreferiti
                string middleValueOfCibiPreferiti = cibiPreferiti[middleIndex];

                // Stampiamo il valore centrale dell'array cibiPreferiti
                Console.WriteLine($"Middle Value: {middleValueOfCibiPreferiti}");
            }
        }
    }
}
