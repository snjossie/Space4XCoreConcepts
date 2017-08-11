using System.Collections.Generic;

namespace Space4XCoreConcepts
{
    public class Colony
    {
        public ICollection<Facility> Facilities { get; set; }

        public string Name { get; set; }

        public FacilitySpecialization Specialization { get; set; }
    }
}