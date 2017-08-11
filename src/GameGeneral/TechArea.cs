using System.Collections.Generic;

namespace Space4XCoreConcepts
{
    public class TechArea 
    {
        public ISet<TechArea> Parents { get; set; }

        public ISet<TechArea> Children { get; set; }

        public string Name { get; set; }

        public int ResearchPointsRequired { get; set; }

    }
}