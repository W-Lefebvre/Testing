// AltDriverConfig.cs
using AltTester.AltTesterUnitySDK.Driver;

public static class AltDriverConfig
{
    private static AltDriver altDriver;

    public static AltDriver GetAltDriver()
    {
        if (altDriver == null)
        {
            altDriver = new AltDriver(host: "192.168.1.13", port: 13000, appName: "__default__");
        }
        return altDriver;
    }

    public static void StopAltDriver()
    {
        altDriver?.Stop();
        altDriver = null;
    }
}
