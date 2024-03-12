namespace Medelberäknaren___Utan_Klasser
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double sum = 0;
            double numberOfValues = 0;

            // en evighetsloop
            while (true)
            {
                // ta input från användaren
                Console.Write("Skriv in ett heltal: ");
                int value = int.Parse(Console.ReadLine());

                // uppdatera summan och antal input från användaren
                sum = sum + value;
                numberOfValues++;

                // skriv ut det nya medelvärdet
                Console.WriteLine("Medelvärdet är " + sum / numberOfValues);
            }
        }
    }
}