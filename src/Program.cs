using System;
using System.Linq;

namespace Space4XCoreConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var shieldComponent = new Component();
            shieldComponent.Name = "Shield Generator I";
            shieldComponent.Attributes.Add(new Attribute { Value = 300f, Kind = AttributeKind.Shield });

            var engineComponent = new Component(); 
            engineComponent.Name = "Ion Engine I";
            engineComponent.Attributes.Add(new Attribute { Value = 10f, Kind = AttributeKind.Engine });

            Console.WriteLine($"Component '{shieldComponent.Name}' generates {shieldComponent.ShieldsGenerated} points of shielding");
            Console.WriteLine($"Component '{engineComponent.Name}' generates {engineComponent.ThrustGenerated} points of thrust");
        }
    }
}
