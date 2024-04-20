using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using ModelLibrary;

namespace DataLibrary
{
    public class RacketRepository
    {
        private Dictionary<string, List<BadmintonRacket>> racketData;

        public RacketRepository()
        {
            racketData = new Dictionary<string, List<BadmintonRacket>>();

            
            ModelData();
        }

        private void ModelData()
        {
            
            racketData["Yonex"] = new List<BadmintonRacket>
        {
            new BadmintonRacket("Yonex", "Astrox 99", "Graphite", 85, 9),
            new BadmintonRacket("Yonex", "Voltric Z-Force II", "Graphene", 88, 8),
            new BadmintonRacket("Yonex", "Nanoflare 800", "Nanocell", 83, 9)
        };

            
            racketData["Victor"] = new List<BadmintonRacket>
        {
            new BadmintonRacket("Victor", "Thruster K Falcon", "Graphene", 85, 9),
            new BadmintonRacket("Victor", "Jetspeed S 12", "Nanocell", 88, 8),
            new BadmintonRacket("Victor", "Auraspeed 90K", "Nano Tec", 83, 9)
        };

            
            racketData["Li-Ning"] = new List<BadmintonRacket>
        {
            new BadmintonRacket("Li-Ning", "Turbo Charging 75D", "Carbon fiber", 85, 9),
            new BadmintonRacket("Li-Ning", "Windstorm 72", "Graphite", 88, 8),
            new BadmintonRacket("Li-Ning", "N9 II", "Nanocell", 83, 9)
        };
        }

        public List<BadmintonRacket> GetRacketsByBrand(string brand)
        {
            if (racketData.ContainsKey(brand))
                return racketData[brand];
            else
                return null;
        }
    }
}
