using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    public class Class1
    {
        private Dictionary<string, Dictionary<int, List<Delegate>>> ev = new Dictionary<string, Dictionary<int, List<Delegate>>>();
        private Dictionary<string, DateTime> lasttime = new Dictionary<string, DateTime>();
        private int litime;
        public Class1(int throtTime)
        {
            litime = throtTime;
        }
        public void Register(string evName, int pr, Delegate evh)
        {
            if (!ev.ContainsKey(evName))
            {
                ev[evName] = new Dictionary<int, List<Delegate>>();
            }
            if (!ev[evName].ContainsKey(pr))
            {
                ev[evName][pr] = new List<Delegate>();
            }
            ev[evName][pr].Add(evh);
        }

        public void Unregister(string evName, int pr, Delegate evh)
        {
            if (ev.ContainsKey(evName))
            {
                if (ev[evName].ContainsKey(pr))
                {
                    ev[evName][pr].Remove(evh);
                }
            }
        }
        public void Send(string evName, object send, EventArgs args)
        {
            if (ev.ContainsKey(evName))
            {
                DateTime minEventTime;
                if (!lasttime.TryGetValue(evName, out minEventTime) || (DateTime.Now - minEventTime).TotalMilliseconds >= litime)
                {
                    lasttime[evName] = DateTime.Now;
                    foreach (int priority in ev[evName].Keys)
                    {
                        foreach (Delegate eventHandler in ev[evName][priority])
                        {
                            eventHandler.DynamicInvoke(send, args);
                        }
                    }
                }
            }
        }
    }
}
