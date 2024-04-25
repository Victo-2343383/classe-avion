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
        private Passager[] _passagers;
        private Section[] _sections;

        public Avion(string pilote, string copilote, string[] agentsDeBord, Passager[] passagers)
        {
            Pilote = pilote;
            Copilote = copilote;
            AgentsDeBord = agentsDeBord;

            Sections = new Section[29];
            InitSections();
            Remplir(passagers);
        }
        private void InitSections()
        {
            for (int i = 0; i < Sections.Length; i++)
            {
                if (i < 4) Sections[i] = new Section(Banc.TypeEnum.Premiere);
                else if (i < 12) Sections[i] = new Section(Banc.TypeEnum.Reguliere);
                else Sections[i] = new Section(Banc.TypeEnum.Economique);
            }
        }
        private void Remplir(Passager[] passagers)
        {
            Array.Sort(passagers);
            foreach (Passager passager in passagers)
            {
                Sections[passager.Numero].AjouterPassager(passager);
            }
        }

        public override string ToString()
        {
            string output = "-----------\n";
            foreach (Section section in Sections)
            {
                output += section.ToString()+"\n";
            }
            output += "-----------";

            return output;
        }


        #region get/set
        public string Pilote        { get => _pilote;       private set => _pilote = value; }
        public string Copilote      { get => _copilote;     private set => _copilote = value; }
        public string[] AgentsDeBord{ get => _agentsDeBord; private set => _agentsDeBord = value; }
        public Passager[] Passagers { get => _passagers;    private set => _passagers = value; }
        public Section[] Sections   { get => _sections;     private set => _sections = value; }
        #endregion
    }
}
