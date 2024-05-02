using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    /// <summary>
    /// classe d'un passager
    /// </summary>
    public class Passager : IComparable<Passager>
    {
        private string _nom;
        private char _lettre;
        private int _numero;
        private DateTime _naissance;

        //ordre des bancs
        private char[] ordre =
        {
            'A',
            'B',
            'C',
            'F',
            'E',
            'D'
        };


        /// <summary>
        /// Constructeur d'un passager avec son nom, sa lettre et son numéro de banc, et sa date de naissance.
        /// </summary>
        /// <param name="nom">nom du passager</param>
        /// <param name="lettre">lettre de son banc</param>
        /// <param name="numero">numéro de son banc</param>
        /// <param name="naissance">date de naissance</param>
        public Passager(string nom, char lettre, int numero, DateTime naissance)
        {
            Nom = nom;
            Lettre = lettre;
            Numero = numero;
            Naissance = naissance;
        }

        /// <summary>
        /// Comparer les passagers pour les mettre en ordre de bancs
        /// </summary>
        /// <param name="other">l'autre passager à comparer</param>
        /// <returns></returns>
        public int CompareTo(Passager? other)
        {
            if (other is null) return 1;
            if (this == other) return 0;
            if (ReferenceEquals(this, other)) return 1;

            if (this.Numero.CompareTo(other.Numero) == 0)
            {
                return Array.IndexOf(ordre, this.Lettre).CompareTo(Array.IndexOf(ordre, other.Lettre));
            }
            else
            {
                return this.Numero.CompareTo(other.Numero);
            }
        }


        #region get/set
        /// <summary>
        /// nom du passager
        /// </summary>
        public string Nom { get => _nom; private set => _nom = value; }
        /// <summary>
        /// lettre de son banc
        /// </summary>
        public char Lettre { get => _lettre; private set => _lettre = value;}
        /// <summary>
        /// numero de son banc
        /// </summary>
        public int Numero { get => _numero; private set => _numero = value; }
        /// <summary>
        /// date de naissance
        /// </summary>
        public DateTime Naissance { get => _naissance; private set => _naissance = value; }
        #endregion
    }
}
