using HarmonyLib;
using BepInEx;
using MockSubnauticaTelemetry.Realization;
using BepInEx.Logging;

namespace MockSubnauticaTelemetry
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class MockSubnauticaTelemetryPlugin : BaseUnityPlugin
    {
        private const string PluginGUID = "by.roker2.subnauticamocktelemetry";
        private const string PluginName = "Subnautica Mock Telemetry";
        private const string PluginVersion = "1.0.0";

        internal static ManualLogSource Log;

        private void Start()
        {
            new Harmony(PluginGUID).PatchAll();
            SubnauticaTelemetry.SubnauticaTelemetryPlugin.AddForceFeedbackProcessor(new MockForceFeedbackProcessor());
            Log = Logger;
        }
    }
}
