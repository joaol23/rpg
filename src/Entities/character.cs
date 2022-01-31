namespace projetoRPG.src.Entities
{
    public class Character
    {
        public Character(string Name, int level, string Classe)
        {
            this.Name = Name;
            this.Level = level;
            this.Class = Classe;
        }
        public string Name;

        public int Level;

        public string Class;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Class;
        }
    }
}