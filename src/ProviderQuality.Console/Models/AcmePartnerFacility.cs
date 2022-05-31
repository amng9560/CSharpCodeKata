using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console.Models
{
    public class AcmePartnerFacility : Award
    {
        public AcmePartnerFacility(int expiresIn, int quality) : base("ACME Partner Facility", expiresIn, quality) { }
    }
}
