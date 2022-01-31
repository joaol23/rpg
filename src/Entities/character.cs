namespace projetoRPG.src.Entities
{
    public class Character
    {
        public Character(string Name)
        {
            this.Name = Name;
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