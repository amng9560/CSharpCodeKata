using ProviderQuality.Console.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    public class Award : IAward
    {
        public string Name { get; set; }

        public int ExpiresIn { get; set; }

        public int Quality { get; set; }


        public Award(string name, int expiresIn, int quantity)
        {
            Name = name;
            ExpiresIn = expiresIn;
            if (quantity < 0 || quantity < 50)
                throw new Exception("The Quality is an invalid number, it needs to be greater than 0 but cannot be any greater than 50");
            Quality = quantity;
        }


        protected int _maxQuality { get; set; } = 50;

        protected int _minQuality { get; set; } = 0;

        public virtual void ProcessExpirationDateUpdate() => ExpiresIn--;

        public virtual void ProcessQualityUpdate()
        {
            ProcessExpirationDateUpdate();

            if (Quality > _minQuality)
            {
                Quality--;
            }

            if (ExpiresIn < 0 && Quality > _minQuality)
            {
                Quality--;
            }
        }
    }
}
