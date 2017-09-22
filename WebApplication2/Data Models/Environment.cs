using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Data_Models
{
    public class Environment
    {
        public int EnvironmentId { get; set; }
        public EnvironmentType Type { get; set; }
        public int Strength { get; set; }
        public bool New { get; set; }
        public bool TempControlled { get; set; }

        public enum EnvironmentType
        {
            Fence,
            Glass,
            Tank,
            Pit,
        }
    }
}