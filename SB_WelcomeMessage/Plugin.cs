using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using FormatWith;

namespace SB_WelcomeMessage
{
    public class Plugin
    {
        public static Plugin Singleton;

        [PluginConfig] public Config Config;

        public const string Version = "1.0.0";

        [PluginPriority(LoadPriority.Highest)]
        [PluginEntryPoint("JoinMessage-System", Version, "Shows a Broadcast Message in the top of the Screen of the joining player.", "SpaceBuddy")]
        void LoadPlugin()
        {
            Singleton = this;
            PluginAPI.Events.EventManager.RegisterEvents(this);
        }

        [PluginEvent(ServerEventType.PlayerJoined)]

        public void OnPlayerJoin(Player player)
        {
            if (Config.wlcAct)
            {
                string JoinText = Config.JoinMessage.FormatWith(new
                {
                    name = player.Nickname
                });
                player.SendBroadcast(JoinText, (ushort)Config.JoinMessageDelay);
            }
        }
    }
}
