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

            attacks[0] = new Attack("teste", 1, 1, 1);
            attacks[1] = new Attack("teste", 1, 1, 2);
            attacks[2] = new Attack("teste", 1, 1, 2);
            attacks[3] = new Attack("teste", 1, 1, 2);

            this.Attacks = attacks;
        }

    }
}