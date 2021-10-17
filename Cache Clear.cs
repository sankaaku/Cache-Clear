using MelonLoader;
using System;
using System.IO;

[assembly: MelonInfo(typeof(CacheClear.Main), "Cache Clear", "1", "kaaku")]
[assembly: MelonGame("VRChat", "VRChat")]


namespace CacheClear
{
    class Main : MelonPlugin
    {
        public override void OnApplicationEarlyStart()
        {
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\VRChat\\VRChat\\Cache-WindowsPlayer", true);
            MelonLogger.Msg(ConsoleColor.Yellow, "Cache was cleared");
        }
    }
}