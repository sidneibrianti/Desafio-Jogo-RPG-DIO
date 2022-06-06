

namespace DesafioJogoRPG1.src.Models
{
    // -------------------
    // Exemplo de Herança
    // -------------------
    internal class Hero : Character
    {
        public Hero(string name, int health, int attack, int defense, ClassType classtype, Races races) : base(name, health, attack, defense, classtype, races)
        {
        }

        void Luck()
        {
            //ToDo
        }
        void Range()
        {
            //ToDo
        }
    }
}
