using System.Collections.Generic;
using System.Linq;
using Space4XCoreConcepts.GameGeneral;

namespace Space4XCoreConcepts
{
    public class Facility : IProgressable
    {
        public ISet<Attribute> Attributes { get; set; } = new HashSet<Attribute>();

        public ISet<TechArea> ResearchRequirements { get; set; } = new HashSet<TechArea>();

        public string Name { get; set; }

        public float MaxHealth { get; set; }

        public float ConstructionPointsToBuild { get; set; }

        public float ResearchPointsGenerated => Attributes.Where(a => a.Kind == AttributeKind.ResearchPointGenerator).SumOrDefault(a => a.Value);

        public float ResearchBonus => Attributes.Where(a => a.Kind == AttributeKind.ResearchBonus).MaxOrDefault(a => a.Value);

        public float PointsRequired { get; set; }
    }
}