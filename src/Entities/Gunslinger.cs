using projetoRPG.src.Actions;

namespace projetoRPG.src.Entities
{
    public class Gunslinger : Character
    {
        public Gunslinger(string Name) : base(Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.Class = "Gunslinger";
            this.Life = 90;
            this.MP = 20;
        }
        public void SetAttacks()
        {
            Attack[] attacks = new Attack[4];

            attacks[0] = new Attack("Pistol", 0, 8, 1);
            attacks[1] = new Attack("Double Shot", 0, 16, 2);
            attacks[2] = new Attack("Vacuum Shot", 10, 20 , 3);
            attacks[3] = new Attack("Fire Shot", 15, 25, 4);

            this.Attacks = attacks;
        }
    }
}