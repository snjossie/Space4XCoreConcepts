using System.Collections.Generic;
using System.Linq;

namespace Space4XCoreConcepts
{
    public class Component
    {
        public string Name { get; set; }

        public ISet<Attribute> Attributes { get; set; } = new HashSet<Attribute>();

        public ISet<TechArea> ResearchRequirements { get; set; } = new HashSet<TechArea>();

        public float ShieldsGenerated => Attributes.Where(a => a.Kind == AttributeKind.Shield).SumOrDefault(a => a.Value);

        public float ThrustGenerated => Attributes.Where(a => a.Kind == AttributeKind.Engine).SumOrDefault(a => a.Value);
    }
}