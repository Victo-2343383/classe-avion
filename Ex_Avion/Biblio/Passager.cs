using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Passager : IComparable<Passager>
    {
        private string _nom;
        private char _lettre;
        private int _numero;
        private DateTime _naissance;

        private char[] ordre =
        {
            'A',
            'B',
            'C',
            'F',
            'E',
            'D'
        };

        public Passager(string nom, char lettre, int numero, DateTime naissance)
        {
            Nom = nom;
            Lettre = lettre;
            Numero = numero;
            Naissance = naissance;
        }

        public int CompareTo(Passager? other)
        {
            if (other == null) return 1;
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
        public string Nom { get => _nom; private set => _nom = value; }
        public char Lettre { get => _lettre; private set => _lettre = value; }
        public int Numero { get => _numero; private set => _numero = value; }
        public DateTime Naissance { get => _naissance; private set => _naissance = value; }
        #endregion
    }
}
