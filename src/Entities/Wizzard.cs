namespace projetoRPG.src.Entities
{
    public class Wizzard : Character
    {
        public Wizzard(string Name, int level, string Classe) : base(Name, level, Classe)
        {
            this.Name = Name;
            this.Level = level;
            this.Class = Classe;            
        }
    }
}