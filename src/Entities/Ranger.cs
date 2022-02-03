using projetoRPG.src.Actions;

namespace projetoRPG.src.Entities
{
    public class Ranger : Character
    {
        public Ranger(string Name) : base(Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.Class = "Ranger";
            this.Life = 80;
            this.MP = 35;
        }
        public void SetAttacks()
        {
            Attack[] attacks = new Attack[4];

            attacks[0] = new Attack("Arrow Shoot", 0, 8, 1);
            attacks[1] = new Attack("Magical Arrow", 7, 17, 2);
            attacks[2] = new Attack("Healing", 15, 14, 3);
            attacks[3] = new Attack("Star Arrows", 20, 30, 4);

            this.Attacks = attacks;
        }

    }
}