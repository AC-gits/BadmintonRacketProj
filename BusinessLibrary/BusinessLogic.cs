using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using DataLibrary;
using ModelLibrary;

namespace BusinessLibrary
{
    public class RacketService
    {
        private RacketRepository racketRepository;

        public RacketService()
        {
            racketRepository = new RacketRepository();
        }

        public List<BadmintonRacket> GetRacketsByBrand(string brand)
        {
            return racketRepository.GetRacketsByBrand(brand);
        }
    }
}
