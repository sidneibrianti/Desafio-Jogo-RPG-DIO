using DesafioJogoRPG1.src.Enums;

namespace DesafioJogoRPG1.src.Entities
{
    // -------------------
    // Exemplo de Herança
    // -------------------
    internal class Enemy : Character
    {
        public Enemy(string name, int health, int attack, int defense, ClassType classtype, Races races) : base(name, health, attack, defense, classtype, races)
        {
        }

        void Special()
        {
            //ToDo
        }
        void Change()
        {
            //ToDo
        }
    }
}
