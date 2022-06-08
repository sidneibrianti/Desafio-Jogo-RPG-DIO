using DesafioJogoRPG1.src.Enums;

namespace DesafioJogoRPG1.src.Entities

{
    internal class Battle
    {
        private Hero _hero;
        private Enemy _enemy;

        

        public void LoadFighting()
        {
            Random? rnd = new();

            // --------------------------
            // Números de itens nos enum
            // --------------------------

            int numberClassType = Enum.GetValues(typeof(ClassType)).Length;

            int numberRaces = Enum.GetValues(typeof(Races)).Length;

            int numberNames = Enum.GetValues(typeof(Names)).Length;

            int randHeroName, randHeroClassType, randHeroRaces, randEnemyName, randEnemyClassType, randEnemyRaces;

            // ------------------------------------
            // Gera os números aleatórios dos enum
            // ------------------------------------

            randHeroName = rnd.Next(1, numberNames + 1);

            randHeroClassType = rnd.Next(1, numberClassType + 1);

            randHeroRaces = rnd.Next(1, numberRaces + 1);

            randEnemyName = rnd.Next(1, numberNames + 1);

            randEnemyClassType = rnd.Next(1, numberClassType + 1);

            randEnemyRaces = rnd.Next(1, numberRaces + 1);


            _hero = new(((Names)randHeroName).ToString(), 100, rnd.Next(1, 21), rnd.Next(1, 21), (ClassType)randHeroClassType, (Races)randHeroRaces);

            _enemy = new(((Names)randEnemyName).ToString(), 100, rnd.Next(1, 21), rnd.Next(1, 21), (ClassType)randEnemyClassType, (Races)randEnemyRaces);

            Console.WriteLine("----- Herói -----");
            Console.WriteLine(_hero);
            Console.WriteLine();
            Console.WriteLine("---- Inimigo ----");
            Console.WriteLine(_enemy);
            Console.WriteLine();
        }

        public void Fighting()
        {
            var blowTotal = 0;
            var blowHero = 0;
            var blowEnemy = 0;
            var defenseBlowHero = 0;
            var defenseBlowEnemy = 0;
            var enemyattacking = true;
            var isBattle = true;
            do
            {
                if (enemyattacking)
                {
                    if (_hero.Defending(_enemy.Attack))
                    {
                        blowEnemy++;
                    } 
                    else
                    {
                        defenseBlowHero++;
                    }
                        

                    if (_hero.Health == 0)
                        isBattle = false;

                    enemyattacking = false;
                }
                else
                {
                    if (_enemy.Defending(_hero.Attack))
                    {
                        blowHero++;
                    }
                    else
                    {
                        defenseBlowEnemy++;
                    }
                        

                    if (_enemy.Health == 0)
                        isBattle = false;

                    enemyattacking = true;
                }

                blowTotal++;
            } while (isBattle);

            Scoreboard(blowHero,defenseBlowHero,blowEnemy,defenseBlowEnemy,blowTotal);

           
        }
        // --------------------------
        // Exemplo de Encapsulamento
        // --------------------------
        private void Scoreboard(int blowHero, int defenseBlowHero, int blowEnemy, int defenseBlowEnemy, int blowTotal)
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Herói: {_hero.Name}");
            Console.WriteLine($"Saúde: {_hero.Health}");
            Console.WriteLine($"Golpes Acertados: {blowHero} - {((double)(blowHero) / blowTotal).ToString("P01")}");
            Console.WriteLine($"Golpes Defendidos: {defenseBlowHero} - {((double)(defenseBlowHero) / blowTotal).ToString("P01")}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Inimigo: {_enemy.Name}");
            Console.WriteLine($"Saúde: {_enemy.Health}");
            Console.WriteLine($"Golpes Acertados: {blowEnemy} - {((double)(blowEnemy) / blowTotal).ToString("P01")}");
            Console.WriteLine($"Golpes Defendidos: {defenseBlowEnemy} - {((double)(defenseBlowEnemy) / blowTotal).ToString("P01")}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Total de golpes: {blowTotal}");

        }

    }
}
