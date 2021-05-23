﻿using System.Threading.Tasks;
using NLog;

namespace l99.driver.@base
{
    public class Collector
    {
        protected ILogger _logger;
        protected Machine _machine;
        protected int _sweepMs;
        public bool LastSuccess { get; set; }
        
        public Collector(Machine machine, int sweepMs = 1000)
        {
            _logger = LogManager.GetLogger(this.GetType().FullName);
            _machine = machine;
            _sweepMs = sweepMs;
        }

        public virtual async Task InitializeAsync()
        {
            
        }

        public virtual async Task CollectAsync()
        {
            
        }
    }
}