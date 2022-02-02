namespace projetoRPG.src.Actions
{
    public class Attack
    {
        public Attack(string name, int MPLost, int Damage, int MinLevel)
        {
            this.Name = name;
            this.MPLost = MPLost;
            this.Damage = Damage;
            this.MinLevel = MinLevel;
        }
        public string Name;

        public int MPLost;

        public int Damage;
        public int MinLevel;
    }
}