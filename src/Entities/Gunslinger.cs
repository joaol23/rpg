namespace projetoRPG.src.Entities
{
    public class Gunslinger : Character
    {
        public Gunslinger(string Name) : base(Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.Class = "Gunslinger";
        }
    }
}