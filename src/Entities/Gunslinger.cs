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

            attacks[0] = new Attack("teste", 1, 1, 1);
            attacks[1] = new Attack("teste", 1, 1, 2);
            attacks[2] = new Attack("teste", 1, 1, 2);
            attacks[3] = new Attack("teste", 1, 1, 2);

            this.Attacks = attacks;
        }
    }
}