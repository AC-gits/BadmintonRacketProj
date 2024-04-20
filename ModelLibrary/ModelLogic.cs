using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class BadmintonRacket
    {
        public string Brand;
        public string Model;
        public string Material;
        public int Weight;
        public int Flexibility;

        public BadmintonRacket(string brand, string model, string material, int weight, int flexibility)
        {
            Brand = brand;
            Model = model;
            Material = material;
            Weight = weight;
            Flexibility = flexibility;
        }
    }
}
