using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class ListePassagers
    {
        private List<Passager> liste;

        public ListePassagers(List<Passager> liste)
        {
            this.liste = liste ?? throw new ArgumentNullException(nameof(liste));
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i] is not null)
                output += (i + " " + liste[i].Nom + " " + liste[i].Lettre +liste[i].Numero + "\n");
            }
            return output;
        }
    }
}
