using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Fantassin : Piece, IDeplacable, IDessinable
    {
        public Fantassin(int posX, int posY) : base(posX, posY)
        {
            
        }

        public void Dessiner()
        {

            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("  o  |");
            Console.WriteLine("--+--|");
            Console.WriteLine("  |  \\");
            Console.WriteLine("// \\\\");
        }

        public void SeDéplacer()
        {
            Console.WriteLine("Je me déplace de 1 case");
            posX += 1;
        }
    }
}
