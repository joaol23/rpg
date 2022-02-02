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

            attacks[0] = new Attack("teste", 1, 1, 1);
            attacks[1] = new Attack("teste", 1, 1, 2);
            attacks[2] = new Attack("teste", 1, 1, 2);
            attacks[3] = new Attack("teste", 1, 1, 2);

            this.Attacks = attacks;
        }
    }
}