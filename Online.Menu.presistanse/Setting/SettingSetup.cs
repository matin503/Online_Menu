using Sanpad.Chmlu.MiningLab.InfraStracture.Framework.Commons;

namespace Online.Menu.presistance.Setting;

internal static class SettingSetup
{
    public static void AddSettings()
    {
        AppSettings.ConnectionString = SettingCommon.GetSetting<String>("ConnectionStrings");
    }
}
