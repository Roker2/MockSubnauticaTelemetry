using SubnauticaTelemetry.ForceFeedback;
using System.Collections.Generic;
using BepInEx.Logging;

namespace MockSubnauticaTelemetry.Realization
{
    class MockForceFeedbackProcessor : IForceFeedbackProcessor
    {
        public void ProcessEvent(ForceFeedbackEvent ffevent)
        {
            Main.Log.LogInfo(ffevent.ToString());
        }

        public void ProcessEvents(ForceFeedbackEvent[] ffevents)
        {
            foreach (var ffevent in ffevents)
            {
                ProcessEvent(ffevent);
            }
        }

        public void ProcessEvents(List<ForceFeedbackEvent> ffevents)
        {
            foreach (var ffevent in ffevents)
            {
                ProcessEvent(ffevent);
            }
        }

        public void StopAllEvents()
        {
            Main.Log.LogInfo("Stop all events");
        }
    }
}
