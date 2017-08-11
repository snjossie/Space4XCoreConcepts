using System.Collections.Generic;

namespace Space4XCoreConcepts
{
    public class Ship
    {
        public ICollection<Component> Components { get; set; }

        public string Name { get; set; }

        public float Size { get; set; }

        public ISet<TechArea> ResearchRequriements { get; set;  }

        public float Health { get; set; }

        public float Fuel { get; set; }

        public ISet<Attribute> Attributes { get; set; }
    }
}
