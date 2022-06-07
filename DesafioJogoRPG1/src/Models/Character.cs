
using DesafioJogoRPG1.src.Enums;

namespace DesafioJogoRPG1.src.Models
{
    internal abstract class Character
    {
        private string? _name;
        private int _health;
        private int _attack;
        private int _defense;
        private ClassType _classtype;
        private Races _races;

        
        public Character(string name,int health,int attack,int defense,ClassType classtype, Races races)
        {
            _name = name;
            if ((health >= 0) && (health <= 100))
            {
                _health = health;
            }
            
            if ((attack > 0) && (attack <= 20))
            {
                _attack = attack;
            }
            if ((defense > 0) && (defense <= 20))
            {
                _defense = defense;
            }

            _classtype = classtype;
            _races = races;
        }
        public string? Name
        { 
            get => _name; 
            set => _name = value;
        }
        public int Health
        {
            get => _health;
            private set
            {
                if ((value >= 0) && (value <= 100))
                {
                    _health = value;
                }
            }
        }
        
        public int Attack {
            get => _attack;
            set
            {
                if ((value > 0) && (value <= 20))
                {
                    _attack = value;
                }
            }

        }
        public int Defense {
            get => _defense;
            set
            {
                if ((value > 0) && (value <= 20))
                {
                    _defense = value;
                }
            }

        }
        public  ClassType ClassType { 
            get => _classtype;
            private set => _classtype = value;
        
        }

        public  Races Races {
            get => _races;
            private set => _races = value;
        }
        // --------------------------
        // Exemplo de Encapsulamento
        // --------------------------
        public bool Defending(int attack)
        {
            
            int ataque = attack + Dices.OneDice(20);
            int defesa = Defense + Dices.OneDice(20);
            int dano = ataque - defesa;
            bool returnDefending = false;
            if (dano > 0)
            {
                _health -= dano;
                if (_health < 0)
                    _health = 0;
                returnDefending = true;
                
            }
            return returnDefending;
        }
        // ------------------------
        // Exemplo de Polimosfismo
        // ------------------------
        public override string ToString()
        {
            return ($"Name: {Name}\nHealth: {Health}\nAttack: {Attack}\nDefense: {Defense}\nClassType: {ClassType}\nRaces: {Races}");
        }

    }
}
