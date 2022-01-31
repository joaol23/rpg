namespace projetoRPG.src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name, int level, string Classe) : base(Name, level, Classe)
        {
            this.Name = Name;
            this.Level = level;
            this.Class = Classe;
        }
    }
}