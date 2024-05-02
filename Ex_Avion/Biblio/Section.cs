using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    /// <summary>
    /// classe d'une section de bancs d'un avion
    /// </summary>
    public class Section
    {
        //déclaration des variables de classe
        private Banc[] _bancsGauche = new Banc[3];
        private Banc[] _bancsDroite = new Banc[3];
        private int _curseur = 0;

        /// <summary>
        /// position des bancs
        /// </summary>
        Dictionary<char, int> positionBancs = new Dictionary<char, int>
        { 
            {'A', 0}, 
            {'B', 1},
            {'C', 2},
            {'F', 3}, 
            {'E', 4},
            {'D', 5},
        };

        /// <summary>
        /// Constructeur d'un banc
        /// </summary>
        /// <param name="type">classe des bancs de la section</param>
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

        /// <summary>
        /// Ajouter un passager à la section
        /// </summary>
        /// <param name="passager">Le passager doit faire parti de la section</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
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

        /// <summary>
        /// ToString qui ne compte pas les rangées
        /// </summary>
        /// <returns>la string</returns>
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
        /// <summary>
        /// ToString qui compte les rangées
        /// </summary>
        /// <param name="num">numéro de la rangée</param>
        /// <returns>la string</returns>
        public string ToString(int num)
        {
            string output = ""+num;
            while (output.Length != 3)
            {
                output += " ";
            }
            output += "|";
            foreach (Banc banc in BancsGauche) { output += banc.ToString(); }
            if (BancsGauche[0].Type == Banc.TypeEnum.Premiere) output += " ";
            output += "| |";
            if (BancsGauche[0].Type == Banc.TypeEnum.Premiere) output += " ";
            foreach (Banc banc in BancsDroite) { output += banc.ToString(); }
            output += "|";
            return output;
        }


        #region get/set
        /// <summary>
        /// bancs à gauche
        /// </summary>
        public Banc[] BancsGauche { get => _bancsGauche; private set => _bancsGauche = value; }
        /// <summary>
        /// bancs à droite
        /// </summary>
        public Banc[] BancsDroite { get => _bancsDroite; private set => _bancsDroite = value; }
        /// <summary>
        /// curseur...
        /// </summary>
        public int Curseur { get => _curseur; private set => _curseur = value; }
        #endregion
    }
}
