

namespace DesafioJogoRPG1.src.Models
{
    internal static class Dices
    {
        internal static int OneDice(int faces)
        {
            Random rnd = new();
            return rnd.Next(1,faces+1);
        }

       
    }
}
