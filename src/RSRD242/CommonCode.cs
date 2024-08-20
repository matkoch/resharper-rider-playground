using System.Text;
using NuGet.Versioning;

namespace RSRD242;

class CommonCode
{
    void M()
    {
        var sb = new StringBuilder();
        var version = NuGetVersion.Parse("1.3.3.7").Version;

        if (version.Major >= 5)
        {
            sb.Append("?view=net-");
            sb.Append(version.Major).Append(".").Append(version.Minor);
        }
        else
        {
            sb.Append("?view=netcore-");
            sb.Append(version.Major).Append(".").Append(version.Minor);
        }
    }
}
