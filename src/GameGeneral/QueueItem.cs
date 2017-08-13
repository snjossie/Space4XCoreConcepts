namespace Space4XCoreConcepts.GameGeneral
{
    public class QueueItem<T> where T : IProgressable
    {
        public T Item { get; set; }

        public float PointsSpent { get; set; }

        public float ProgressPercent { get { return PointsSpent / Item.PointsRequired; } } 

        public bool IsDone { get { return PointsSpent >= Item.PointsRequired; } }
    }
}