using System.Collections.Generic;
namespace macOs.Applications
{
    public class Application
    {
        public string ApplicationName = string.Empty;
        public bool IsApplicationOpen = false;
        public string AppIcon = string.Empty;
        public Type? ComponentType { get; set; }
    };
}
