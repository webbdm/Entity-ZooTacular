using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Data_Models
{
    public class Zookeeper
    {
        public int ZookeeperId { get; set; }
        public string Name { get; set; }
        public int AnimalId { get; set; }
        public bool FullTime { get; set; }
        public bool Rookie { get; set; }
    }
}