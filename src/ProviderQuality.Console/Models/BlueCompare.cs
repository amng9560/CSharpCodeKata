using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console.Models
{
    public class BlueCompare : Award
    {
        public BlueCompare(int expiresIn, int quality) : base("Blue Compare", expiresIn, quality) { }

        public override void ProcessQualityUpdate()
        {
            ProcessExpirationDateUpdate();

            if (ExpiresIn > 0)
            {
                Quality++;
            }

            if (ExpiresIn < 11 && Quality < 50)
            {
                Quality++;
            }
            
            if (ExpiresIn < 6 && Quality < 50)
            {
                Quality++;
            }
            
            if(!(ExpiresIn > 0 && ExpiresIn < 11 && Quality < 50 && ExpiresIn < 6))
            {
                Quality = 0;
            }
        }
    }
}
