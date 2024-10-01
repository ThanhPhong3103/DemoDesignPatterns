using System;
using System.Collections.Generic;

namespace Singleton.RealWorld
{
    public class LoadBalancer
    {
        private static LoadBalancer instance;
        private List<string> servers = new List<string>();
        private Random random = new Random();
        private static readonly object locker = new object();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Double-checked locking
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
            return instance;
        }

        // Simple random load balancer
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }
    }
}
