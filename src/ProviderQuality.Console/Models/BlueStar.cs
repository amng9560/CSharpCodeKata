using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console.Models
{
    public class BlueStar : Award
    {
        public BlueStar(int expiresIn, int quality) : base("Blue Star", expiresIn, quality) { }

        public override void ProcessQualityUpdate()
        {
            ProcessExpirationDateUpdate();

            if (ExpiresIn != 0 && ExpiresIn > 0)
            {
                Quality -= 1;
            }

            if (ExpiresIn == 0 && Quality > 0)
            {
                Quality -= 2;
            }

            if (Quality > 50)
            {
                Quality = 50;
            }

            if (Quality <= 0)
            {
                Quality = 0;
                return;
            }
        }
    }
}
