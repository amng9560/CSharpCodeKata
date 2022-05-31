using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console.Models
{
    public class BlueDistinctionPlus : Award
    {
        public BlueDistinctionPlus(int expiresIn, int quality) : base("Blue Distinction Plus", expiresIn, quality)
        {
            Quality = 80;
        }
    }
}
