using System.Collections.Generic;

namespace Space4XCoreConcepts
{
    public class Ship
    {
        public ISet<Attribute> Attributes { get; set; } = new HashSet<Attribute>();
        
        public ICollection<Component> Components { get; set; } = new List<Component>();

        public ISet<TechArea> ResearchRequirements { get; set; } = new HashSet<TechArea>();

        public string Name { get; set; }

        public float Size { get; set; }

        public float Health { get; set; }

        public float Fuel { get; set; }
    }
}
