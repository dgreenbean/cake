public class SolutionConfigurationPlatformEqualityComparer : IEqualityComparer<SolutionConfigurationPlatform>
{
    public static SolutionConfigurationPlatformEqualityComparer Comparer = new SolutionConfigurationPlatformEqualityComparer();

    public bool Equals(SolutionConfigurationPlatform x, SolutionConfigurationPlatform y)
    {
        if (object.ReferenceEquals(x, y))
        {
            return true;
        }
        if (x==null||y==null)
        {
            return false;
        }
        return  StringComparer.Ordinal.Equals(x.Configuration, y.Configuration) &&
                StringComparer.Ordinal.Equals(x.Platform, x.Platform);
    }

    public int GetHashCode(SolutionConfigurationPlatform obj)
    {
        if (obj==null) return 0;
        return new [] {
            StringComparer.Ordinal.GetHashCode(obj.Configuration),
            StringComparer.Ordinal.GetHashCode(obj.Platform)
        }.GetHashCode();
    }
}
