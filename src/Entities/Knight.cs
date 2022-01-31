namespace projetoRPG.src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name) : base(Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.Class = "Knight";
        }
    }
}