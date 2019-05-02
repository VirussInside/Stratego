using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.ReadKey();

            Console.Clear();

            List<Piece> listePieces = new List<Piece>();
            listePieces.Add(new Fantassin(0,0));
            listePieces.Add(new Eclaireur(20, 10));
            listePieces.Add(new Jeep(30, 20));
            listePieces.Add(new MineExplosive(20, 35));

            foreach (IDessinable piece in listePieces) {
                piece.Dessiner();
            }

            foreach (IDeplacable piece in listePieces)
            {
                piece.SeDéplacer();
            }

            foreach (IDessinable piece in listePieces)
            {
                piece.Dessiner();
            }

        }
    }
}
