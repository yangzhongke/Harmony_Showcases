namespace HarmonyDemoOnlyLib1;

public static class LicenceManager
{
    private static string _key;
    public static void SetKey(string key)
    {
        _key = key;
    }

    internal static void Check()
    {
        if (string.IsNullOrWhiteSpace(_key))
        {
            throw new ApplicationException("No Licence Found");
        }

        if (_key[0] != 'a')
        {
            throw new ApplicationException("Wrong Licence");
        }
    }
}