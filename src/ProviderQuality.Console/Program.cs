using System.Collections.Generic;
using ProviderQuality.Console.Models;

namespace ProviderQuality.Console
{
    public class Program
    {
        public IList<Award> Awards
        {
            get;
            set;
        }

        // TODO: PLEASE READ THIS DISCLAIMER NOTE
        // HUDE DISCLAIMER! I don't have Dotnet Framework 4.5 installed because I don't think it's wise to keep using a version that has reached the end of life.
        // I tried my best to write logic that fit the criteria. If I were to refactor this I would update the version. It'd be best to update at the version that you're using to .Net Core 3.1 or .NET 6
        static void Main(string[] args)
        {
            System.Console.WriteLine("Updating award metrics...!");

            var app = new Program()
            {
                Awards = new List<Award>
                {
                    new GovQualityPlus (10, 20),
                    new BlueStar (2, 0),
                    new AcmePartnerFacility (5, 7),
                    new BlueDistinctionPlus ( 0, 80),
                    new BlueCompare (15, 20),
                    new TopConnectedProviders (3, 6)
                }

            };

            app.UpdateQuality();

            foreach(var award in app.Awards)
            {
                System.Console.WriteLine($"Award:{award.Name}, Quality: {award.Quality}, Will Expire in {award.ExpiresIn} Days");
                System.Console.WriteLine("----------");
            }

            System.Console.ReadKey();

        }

        public void UpdateQuality()
        {
            foreach(var award in Awards)
            {
                award.ProcessQualityUpdate();
            }
        }

    }

}
