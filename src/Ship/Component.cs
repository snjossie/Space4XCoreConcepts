using System.Collections.Generic;

namespace Space4XCoreConcepts
{
    public class Component
    {
        public ISet<Attribute> Attributes { get; set; } 

        public string Name { get; set; }

        public ISet<TechArea> ResearchRequrements { get; set; }
    }
}