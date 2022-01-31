namespace projetoRPG.src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name) : base(Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.Class = "Knight";
            this.Life = 110;
            this.MP = 10;
        }
    }
}