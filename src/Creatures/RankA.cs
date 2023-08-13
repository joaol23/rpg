using projetoRPG.src.Actions;

namespace projetoRPG.src.Creatures
{
    public class RankA : Monsters
    {
        public RankA (string name, int life)
        {
            this.Name = name;
            this.Life = life;
            this.Rank = 'E';
        }
        public void SetAttacks()    
        {
            Attack[] attacks = new Attack[2];

            attacks[0] = new Attack("Scratch", 0, 7, 1);
            attacks[1] = new Attack("Super Attack", 0, 10, 1);

            this.Attacks = attacks;
        }
        
    }
}