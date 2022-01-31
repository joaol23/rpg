namespace projetoRPG.src.Entities
{
    public class Wizzard : Character
    {
        public Wizzard(string Name) : base(Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.Class = "Wizzard";            
        }
    }
}