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

        public string Info()
        {
            var message = "     A classe " + this.Class + " possui:\n"
            + "         " + this.Life + "/" + this.Life + " de vida.\n"
            + "         " + this.MP + "/" + this.MP + " de mana.\n\n"
            + "    Ataques:\n\n";

            for (var i = 0;i < this.Attacks.Length; i++){
                message += "    " + this.Attacks[i] + "    ";
                if(i % 2 != 0){
                    message += "\n";
                }
            }

            
            return message;
        }
    }
}