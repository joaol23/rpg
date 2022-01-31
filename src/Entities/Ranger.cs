namespace projetoRPG.src.Entities
{
    public class Ranger : Character
    {
        public Ranger(string Name) : base(Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.Class = "Ranger";
            this.Life = 80;
            this.MP = 35;
        }

    }
}