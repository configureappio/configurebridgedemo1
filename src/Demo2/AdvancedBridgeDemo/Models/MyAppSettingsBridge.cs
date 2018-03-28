using System;
using AdvancedBridgeDemo.Configuration;
using Microsoft.Extensions.Options;

namespace AdvancedBridgeDemo.Models
{
    public class MyAppSettingsBridge : IMyAppSettings
    {
        private readonly IOptionsSnapshot<MyAppSettingsReader> _optionsConfig;
        public MyAppSettingsBridge(IOptionsSnapshot<MyAppSettingsReader> optionsConfig)
        {
            _optionsConfig = optionsConfig ?? throw new ArgumentNullException(nameof(optionsConfig));
        }

        public string ApplicationName => _optionsConfig.Value.ApplicationName;
        public int CountOfItems => _optionsConfig.Value.CountOfItems;
    }
}
