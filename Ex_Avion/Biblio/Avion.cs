using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Avion
    {
        private string _pilote;
        private string _copilote;
        private string[] _agentsDeBord;
        private Section[] _sections;

        private char[] ordre =
        {
            'A',
            'B',
            'C',
            'F',
            'E',
            'D'
        };

        public Avion(string pilote, string copilote, string[] agentsDeBord, Passager[] passagers)
        {
            _pilote = pilote;
            _copilote = copilote;
            _agentsDeBord = agentsDeBord;
        }

        private void Remplir(Passager[] passagers)
        {
            
        }
    }
}
