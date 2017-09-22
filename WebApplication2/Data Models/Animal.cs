using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Data_Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Nickname { get; set; }
        public string Species { get; set; }
        public int ZookeeperId { get; set; }
        public int EnvironmentId { get; set; }
    }
}