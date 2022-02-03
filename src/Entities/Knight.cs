using projetoRPG.src.Actions;

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
        public void SetAttacks()
        {
            Attack[] attacks = new Attack[4];

            attacks[0] = new Attack("Slash", 0, 6, 1);
            attacks[1] = new Attack("Fire Sword", 5, 15, 2);
            attacks[2] = new Attack("Multiple Slash", 0, 24, 3);
            attacks[3] = new Attack("Excalibur", 15, 30, 4);

            this.Attacks = attacks;
        }
    }
}