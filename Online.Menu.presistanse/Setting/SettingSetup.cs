using Online.Menu.InfraStructure.Framework.Commons;

namespace Online.Menu.presistance.Setting;

internal static class SettingSetup
{
    public static void AddSettings()
    {
        AppSettings.ConnectionString = SettingCommon.GetSetting<string>("ConnectionStrings");
    }
}
