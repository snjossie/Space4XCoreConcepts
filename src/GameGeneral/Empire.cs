
using System.Collections.Generic;
using System.Linq;

namespace Space4XCoreConcepts.GameGeneral
{
    public class Empire
    {
        public Race Race { get; set; }

        public ISet<Colony> Colonies { get; set; } = new HashSet<Colony>();

        public Queue<QueueItem<TechArea>> ResearchQueue { get; set; } = new Queue<QueueItem<TechArea>>();

        public float ResearchPointsPerTurn 
        { 
            get 
            {
                if(!Colonies.Any()) { return 0; }

                // TODO: Racial bonus for research. Race.Attributes.Where(a => a.Kind == ResearchBonus)?.Max(a => a.Value) ?? 0;
                var researchBonus = 0;
                var colonyResearch = Colonies.Sum(c => c.ResearchPointsGenerated);

                return colonyResearch + researchBonus * colonyResearch;
            }

        }
    }
}