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
        public int Life;
        public int MP;

        public object[] Attacks;

        public override string ToString()
        {
            return this.Name + " level:" + this.Level + " " 
            + this.Class + " " + this.Life + " de vida " 
            + this.MP + " de mana";
        }
    }
}