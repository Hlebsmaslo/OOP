using System;
using System.Collections.Generic;


namespace Lab4._1
{
    public delegate void EventHandler(object sender, EventArgs args);

    public class Class1
    {
        private Dictionary<string, EventHandler> ev = new Dictionary<string, EventHandler>();
        private Dictionary<string, DateTime> lasttime = new Dictionary<string, DateTime>();
        public void RegisterEventHandler(string eventName, EventHandler handler)
        {
            if (!ev.ContainsKey(eventName))
            {
                ev[eventName] = null;
            }

            ev[eventName] += handler;
        }
        public void UnregisterEventHandler(string eventName, EventHandler handler)
        {
            if (ev.ContainsKey(eventName))
            {
                ev[eventName] -= handler;
            }
        }
        public void TriggerEvent(string eventName, EventArgs args, int throttleMilliseconds)
        {
            if (ev.ContainsKey(eventName))
            {
                DateTime lastTimeTriggered;
                if (!lasttime.TryGetValue(eventName, out lastTimeTriggered))
                {
                    lastTimeTriggered = DateTime.MinValue;
                }
                if (DateTime.Now.Subtract(lastTimeTriggered).TotalMilliseconds >= throttleMilliseconds)
                {
                    ev[eventName]?.Invoke(this, args);
                    lasttime[eventName] = DateTime.Now;
                }
            }
        }
    }
}
