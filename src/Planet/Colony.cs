using System.Collections.Generic;
using System.Linq;
using Space4XCoreConcepts.GameGeneral;

namespace Space4XCoreConcepts
{
    public class Colony
    {
        public ICollection<Facility> Facilities { get; set; }

        public Queue<QueueItem<Facility>> ConstructionQueue { get; set; }

        public FacilitySpecialization Specialization { get; set; }

        public string Name { get; set; }

        public float ResearchPointsGenerated 
        {
            get 
            { 
                var researchBonus = Facilities.MaxOrDefault(f => f.ResearchBonus);
                var researchAmount = Facilities.SumOrDefault(f => f.ResearchPointsGenerated);

                return researchAmount + (researchBonus * researchAmount);
            }
        }
    }
}