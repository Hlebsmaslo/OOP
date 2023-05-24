using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4._3
{
    public class EventBus
    {
        private Dictionary<string, Dictionary<int, List<Delegate>>> eventHandlers = new Dictionary<string, Dictionary<int, List<Delegate>>>();
        private Dictionary<string, DateTime> lastEventTime = new Dictionary<string, DateTime>();
        private readonly int Retries1;
        private readonly int Delay2;
        private readonly int Delay1;
        private readonly double delayM;

        public EventBus(int maxRetries, int minDelay, int maxDelay, double delayMultiplier)
        {
            this.Retries1 = maxRetries;
            this.Delay2 = minDelay;
            this.Delay1 = maxDelay;
            this.delayM = delayMultiplier;
        }

        public void Register(string eventName, int priority, Delegate eventHandler)
        {
            if (!eventHandlers.ContainsKey(eventName))
            {
                eventHandlers[eventName] = new Dictionary<int, List<Delegate>>();
            }
            if (!eventHandlers[eventName].ContainsKey(priority))
            {
                eventHandlers[eventName][priority] = new List<Delegate>();
            }
            eventHandlers[eventName][priority].Add(eventHandler);
        }

        public void Unregister(string eventName, int priority, Delegate eventHandler)
        {
            if (eventHandlers.ContainsKey(eventName))
            {
                if (eventHandlers[eventName].ContainsKey(priority))
                {
                    eventHandlers[eventName][priority].Remove(eventHandler);
                }
            }
        }

        public void Send(string eventName, object sender, EventArgs args)
        {
            if (eventHandlers.ContainsKey(eventName))
            {
                DateTime minEventTime;
                if (!lastEventTime.TryGetValue(eventName, out minEventTime) || (DateTime.Now - minEventTime).TotalMilliseconds >= GetDelay())
                {
                    lastEventTime[eventName] = DateTime.Now;
                    for (int retries = 0; retries < Retries1; retries++)
                    {
                        foreach (int priority in eventHandlers[eventName].Keys)
                        {
                            foreach (Delegate eventHandler in eventHandlers[eventName][priority])
                            {
                                eventHandler.DynamicInvoke(sender, args);
                            }
                        }

                        if ((DateTime.Now - lastEventTime[eventName]).TotalMilliseconds >= GetDelay())
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(GetDelay());
                        }
                    }
                }
            }
        }

        private int GetDelay()
        {
            int currentDelay = Delay2;
            if (Delay1 > Delay2)
            {
                Random random = new Random();
                currentDelay = (int)(currentDelay * delayM * (1 + random.NextDouble()));
                currentDelay = Math.Min(currentDelay, Delay1);
            }
            return currentDelay;
        }

    }
}
