using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console.Models.Interface
{
    public interface IAward
    {
        string Name { get; }
        int ExpiresIn { get; set; }
        int Quality { get; set; }
        void ProcessQualityUpdate();
        void ProcessExpirationDateUpdate();
    }
}
