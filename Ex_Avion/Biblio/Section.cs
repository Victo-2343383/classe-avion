using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Section
    {
        private Banc[] _bancsGauche = new Banc[3];
        private Banc[] _bancsDroite = new Banc[3];
        private int _curseur = 0;

        Dictionary<char, int> positionBancs = new Dictionary<char, int>
        { 
            {'A', 0}, 
            {'B', 1},
            {'C', 2},
            {'F', 3}, 
            {'E', 4},
            {'D', 5},
        };

        public Section(Banc.TypeEnum type)
        {
            if (type == Banc.TypeEnum.Premiere)
            {
                BancsGauche = new Banc[] {
                new Banc(type),
                new Banc(type)
            };
                BancsDroite = new Banc[]{
                new Banc(type),
                new Banc(type)
            };
            }
            else
            {
                BancsGauche = new Banc[] {
                new Banc(type),
                new Banc(type),
                new Banc(type)
            };
                BancsDroite = new Banc[]{
                new Banc(type),
                new Banc(type),
                new Banc(type)
            };
            }
        }
        public void AjouterPassager(Passager passager)
        {
            if (passager.Numero >= Curseur)
            {
                if (Curseur < 3 && positionBancs[passager.Lettre] < 3)
                {
                    BancsGauche[positionBancs[passager.Lettre]].Passager = passager;
                }
                else if (Curseur < 6)
                {
                    BancsDroite[5 - positionBancs[passager.Lettre]].Passager = passager;
                }
                else { throw new ArgumentOutOfRangeException(); }

                Curseur = positionBancs[passager.Lettre];
            }
            else throw new ArgumentOutOfRangeException("Conflit d'espace. Vous avez sur-booké.");
        }

        public override string ToString()
        {
            string output = "|";
            foreach (Banc banc in BancsGauche){ output += banc.ToString(); }
            if (BancsGauche[0].Type == Banc.TypeEnum.Premiere) output += " ";
            output += "| |";
            if (BancsGauche[0].Type == Banc.TypeEnum.Premiere) output += " ";
            foreach (Banc banc in BancsDroite) { output += banc.ToString(); }
            output += "|";
            return output;
        }


        #region get/set
        public Banc[] BancsGauche { get => _bancsGauche; private set => _bancsGauche = value; }
        public Banc[] BancsDroite { get => _bancsDroite; private set => _bancsDroite = value; }
        public int Curseur { get => _curseur; private set => _curseur = value; }
        #endregion
    }
}
