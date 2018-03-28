using System;

namespace AdvancedBridgeDemo.Configuration
{
    public interface IMyAppSettings
    {
        string ApplicationName { get; }

        int CountOfItems { get; }
    }
}

