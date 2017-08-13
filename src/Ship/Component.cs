using System.Collections.Generic;
using System.Linq;

namespace Space4XCoreConcepts
{
    public class Component
    {
        public string Name { get; set; }

        public ISet<Attribute> Attributes { get; set; } = new HashSet<Attribute>();

        public ISet<TechArea> ResearchRequrements { get; set; } = new HashSet<TechArea>();

        public float ShieldsGenerated
        {
            get { return Attributes.Where(a => a.Kind == AttributeKind.Shield).Sum(a => a.Value); }
        }

        public float ThrustGenerated 
        {
            get { return Attributes.Where(a => a.Kind == AttributeKind.Engine).Sum(a => a.Value); }
        }
    }
}