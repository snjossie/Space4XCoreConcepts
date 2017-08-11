using System.Collections.Generic;

namespace Space4XCoreConcepts
{
    public class Race
    {
        public string Name { get; set; }

        public ISet<Attribute> Attributes { get; set; }
    }
}