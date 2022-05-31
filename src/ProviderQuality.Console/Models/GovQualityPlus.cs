using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console.Models
{
    public class GovQualityPlus : Award
    {
        public GovQualityPlus(int expiresIn, int quality) : base("Gov Quality Plus", expiresIn, quality) { }
    }
}
