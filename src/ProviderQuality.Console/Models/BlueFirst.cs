using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console.Models
{
    public class BlueFirst : Award
    {
        public BlueFirst(int expiresIn, int quality) : base("Blue First", expiresIn, quality) { }

        public override void ProcessQualityUpdate()
        {
            ProcessExpirationDateUpdate();

            if (ExpiresIn == 0 && Quality < 50)
            {
                Quality += 1;
            }

            if (ExpiresIn != 0 && ExpiresIn > 0 && Quality < 50)
            {
                Quality++;
            }

            if (Quality < 0)
            {
                Quality++;
            }
        }

    }
}
