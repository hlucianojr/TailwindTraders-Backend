using CsvHelper.Configuration;
using Tailwind.Traders.Profile.Api2.Csv;

namespace Tailwind.Traders.Profile.Api2.Helpers
{
    public sealed class ProfilesMap : ClassMap<ProfileData>
    {
        public ProfilesMap()
        {
            AutoMap();
        }
    }
}
