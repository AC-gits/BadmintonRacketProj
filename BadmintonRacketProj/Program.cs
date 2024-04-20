using ModelLibrary;
using BusinessLibrary;


namespace BadmintonRacketProj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RacketService racketService = new RacketService();

            Console.WriteLine("Choose a badminton racket brand to see its specifications:");
            Console.WriteLine("1. Yonex");
            Console.WriteLine("2. Victor");
            Console.WriteLine("3. Li-Ning");

            string userInput = Console.ReadLine();
            string brand = "";

            switch (userInput)
            {
                case "1":
                    brand = "Yonex";
                    break;
                case "2":
                    brand = "Victor";
                    break;
                case "3":
                    brand = "Li-Ning";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            List<BadmintonRacket> rackets = racketService.GetRacketsByBrand(brand);

            if (rackets != null)
            {
                Console.WriteLine($"\nAvailable {brand} rackets:");
                foreach (var racket in rackets)
                {
                    Console.WriteLine($"Model: {racket.Model}");
                }

                Console.WriteLine("\nChoose a model to see its specifications:");
                string selectedModel = Console.ReadLine();

                BadmintonRacket selectedRacket = rackets.Find(r => r.Model == selectedModel);
                if (selectedRacket != null)
                {
                    Console.WriteLine("\nSpecifications of selected racket:");
                    Console.WriteLine($"Brand: {selectedRacket.Brand}");
                    Console.WriteLine($"Model: {selectedRacket.Model}");
                    Console.WriteLine($"Material: {selectedRacket.Material}");
                    Console.WriteLine($"Weight: {selectedRacket.Weight} grams");
                    Console.WriteLine($"Flexibility: {selectedRacket.Flexibility}");
                }
                else
                {
                    Console.WriteLine("Invalid model choice.");
                }
            }
            else
            {
                Console.WriteLine("No rackets found for the selected brand.");
            }
        }
    }
}
