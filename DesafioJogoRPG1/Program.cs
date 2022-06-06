using DesafioJogoRPG1.src.Models;


char keyPress;

do
{
    Console.Clear();

    Battle battle = new();

    battle.LoadFighting();

    battle.Fighting();

    Console.WriteLine();

    Console.Write("Para sair digite (X):");

    keyPress = Console.ReadKey().KeyChar;
    

} while ((keyPress != 'x') && (keyPress != 'X'));



