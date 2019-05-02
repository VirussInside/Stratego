using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Piece
    {
        protected int posX;
        protected int posY;

        public Piece(int posX, int posY) {
            this.posX = posX;
            this.posY = posY;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
