namespace Space4XCoreConcepts
{
    public class AttributeKind
    {
        public static readonly AttributeKind Shield = new AttributeKind("Shield");
        public static readonly AttributeKind Weapon = new AttributeKind("Weapon");
        public static readonly AttributeKind Engine = new AttributeKind("Engine");
        public static readonly AttributeKind Construction = new AttributeKind("Construction");
        public static readonly AttributeKind ResearchBonus = new AttributeKind("ResearchBonus");
        public static readonly AttributeKind ResearchPointGenerator = new AttributeKind("ResearchPointGenerator");

        private AttributeKind(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is AttributeKind))
            {
                return false;
            }

            return this == (AttributeKind)obj;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public static bool operator ==(AttributeKind left, AttributeKind right)
        {
            if (ReferenceEquals(left, right)) { return true; }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) { return false; }

            return left.Name == right.Name;
        }

        public static bool operator !=(AttributeKind left, AttributeKind right)
        {
            return !(left == right);
        }
    }
}