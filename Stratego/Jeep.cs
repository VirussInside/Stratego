using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Jeep : Piece, IDeplacable, IDessinable
    {
        public Jeep(int posX, int posY) : base(posX, posY)
        {

            this.posX = posX;
            this.posY = posY;

        }

        public void Dessiner()
        {
            Console.WriteLine(" ___");
            Console.WriteLine("|  |_");
            Console.WriteLine("'O-O-'");
        }

        public void SeDéplacer()
        {
            Console.WriteLine("Vroum vvroum");
            posX += 5;
        }
    }
}

