using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Eclaireur : Piece, IDeplacable, IDessinable
    {

        public Eclaireur(int posX, int posY) : base(posX, posY) {

        }


        public void Dessiner()
        {
            Console.WriteLine("  o");
            Console.WriteLine("--+--");
            Console.WriteLine("  |");
            Console.WriteLine("// \\\\");
        }

        public void SeDéplacer()
        {
            Console.WriteLine("Je me déplace de 3 cases");
            posX += 3;
        }
    }
}
