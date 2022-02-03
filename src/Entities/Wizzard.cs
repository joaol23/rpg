using projetoRPG.src.Actions;

namespace projetoRPG.src.Entities
{
    public class Wizzard : Character
    {
        public Wizzard(string Name) : base(Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.Class = "Wizzard";
            this.Life = 70;
            this.MP = 60;
        }

        public void SetAttacks()
        {
            Attack[] attacks = new Attack[4];

            attacks[0] = new Attack("FireBall", 5, 7, 1);
            attacks[1] = new Attack("Ice Spikes", 10, 15, 2);
            attacks[2] = new Attack("Toxic Smoke", 12, 20, 3);
            attacks[3] = new Attack("Black Hole", 20, 28, 4);

            this.Attacks = attacks;
        }
    }
}