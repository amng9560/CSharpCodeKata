using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console.Models
{
    public class TopConnectedProviders : Award
    {
        public TopConnectedProviders(int expiresIn, int quality) : base("Top Connection Providers", expiresIn, quality) { }
    }
}
