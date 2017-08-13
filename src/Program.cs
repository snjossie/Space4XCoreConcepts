using System;
using System.Collections.Generic;
using System.Linq;
using Space4XCoreConcepts.GameGeneral;

namespace Space4XCoreConcepts
{
    class Program
    {
        static void Main(string[] args)
        {

            var praxis = new Colony();
            praxis.Facilities = CreateFacilities(0.05f);

            var qonos = new Colony();
            qonos.Facilities = CreateFacilities(0.10f);

            var empire = new Empire();
            empire.Colonies = new HashSet<Colony> { praxis, qonos };

            Console.WriteLine($"The Empire generates {empire.ResearchPointsPerTurn:N0} research points per turn");
        }


        private static void DemoComponentAttributes()
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

        private static ICollection<Facility> CreateFacilities(float researchBonus)
        {
            var facilities = new List<Facility>();

            facilities.Add(new Facility
            {
                Name = "Central Computer Complex", 
                Attributes = 
                { 
                    new Attribute { Kind = AttributeKind.ResearchBonus, Value = researchBonus } ,
                    new Attribute { Kind = AttributeKind.ResearchPointGenerator, Value = 100 }
                },
            });

            facilities.Add(new Facility
            {
                Name = "Research Complex", 
                Attributes = 
                { 
                    new Attribute { Kind = AttributeKind.ResearchPointGenerator, Value = 400 }
                },                
            });

            return facilities;
        }
    }
}
