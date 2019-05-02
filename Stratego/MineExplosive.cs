using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class MineExplosive : Piece, IDessinable
    {
        public MineExplosive(int posX, int posY) : base(posX, posY)
        {

        }

        public void Dessiner()
        {
            Console.WriteLine(" *");
            Console.WriteLine("***");
            Console.WriteLine(" *");
        }
    }
}
