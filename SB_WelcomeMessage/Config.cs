using System.ComponentModel;

namespace SB_WelcomeMessage
{
    public class Config
    {
        [Description("just de/activates the plugin")]
        public bool wlcAct { get; set; } = true;

        [Description("Join message delay")]
        public int JoinMessageDelay { get; set; } = 5;
        
        [Description("Join Message Text ({name} specifies the name of the joining player). For Rich Text Editing you can use this Guide -> https://sites.google.com/view/scpsl-config/unity-rich-text")]
        public string JoinMessage { get; set; } = "<b><color=#E8002A>Welcome on the YOUR COMMUNITY NAME Community</color>,</b> <i><color=#EB0079>{name}</color></i><b>!</b>";
    }
}
