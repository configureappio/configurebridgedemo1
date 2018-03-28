using AdvancedBridgeDemo.Configuration;

namespace AdvancedBridgeDemo.Models
{
    public class MyAppSettingsReader : IMyAppSettings
    {
        public string ApplicationName { get;  set; }

        public int CountOfItems { get; set; }
        
    }
}
