using System.Collections.Generic;
using System.Linq;

namespace Space4XCoreConcepts
{
    public class Facility
    {
        public ISet<Attribute> Attributes { get; set; } = new HashSet<Attribute>();

        public string Name { get; set; }

        public float Health { get; set; }

        public ISet<TechArea> ResearchRequirements { get; set; }

        public int ResearchPointsGenerated
        {
            get
            {
                var researchBonus = Attributes.Where(a => a.Kind == AttributeKind.ResearchBonus)
                    .Sum(a => a.Value);

                var researchPoints = Attributes.Where(a => a.Kind == AttributeKind.ResearchPointGenerator)
                    .Sum(a => a.Value);

                return (int)(researchBonus * researchPoints);
            }
        }
    }
}