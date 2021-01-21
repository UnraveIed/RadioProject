using RadioProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioProject.Entities.Concrete
{
    public class Radio :IEntity
    {
        public int RadioId { get; set; }
        public string Name { get; set; }
        public double Frequency { get; set; }
        public bool isOnline { get; set; }
        public override string ToString()
        {
            return $"{RadioId,-10} {Name,-15} {Frequency,-15} {isOnline,-5}";
        }
    }
}
