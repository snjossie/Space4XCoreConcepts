using System.Collections.Generic;
using Space4XCoreConcepts.GameGeneral;

namespace Space4XCoreConcepts
{
    public class TechArea : IProgressable
    {
        public ISet<TechArea> Parents { get; set; }

        public ISet<TechArea> Children { get; set; }

        public string Name { get; set; }

        public int ResearchPointsRequired { get; set; }

        public float PointsRequired { get; set; }
    }
}