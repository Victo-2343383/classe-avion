using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    /// <summary>
    /// classe d'un avion
    /// </summary>
    public class Avion
    {
        private string _pilote;
        private string _copilote;
        private string[] _agentsDeBord;
        private Section[] _sections;

        /// <summary>
        /// constructeur d'un avion
        /// </summary>
        /// <param name="pilote">nom du pilote</param>
        /// <param name="copilote">nom du copilote</param>
        /// <param name="agentsDeBord">noms des agents de bords</param>
        /// <param name="passagers">liste des passagers à mettre dans l'avion</param>
        public Avion(string pilote, string copilote, string[] agentsDeBord, Passager[] passagers)
        {
            Pilote = pilote;
            Copilote = copilote;
            AgentsDeBord = agentsDeBord;

            Sections = new Section[29];
            InitSections();
            Remplir(passagers);
        }
        /// <summary>
        /// Initier les objets des sections et les attribuer à l'avion (en crée 29)
        /// </summary>
        private void InitSections()
        {
            for (int i = 0; i < Sections.Length; i++)
            {
                if (i < 4) Sections[i] = new Section(Banc.TypeEnum.Premiere);
                else if (i < 12) Sections[i] = new Section(Banc.TypeEnum.Reguliere);
                else Sections[i] = new Section(Banc.TypeEnum.Economique);
            }
        }
        /// <summary>
        /// remplis les rangées avec les passagers envoyés (ne pas envoyer de positions dupliquées ou quelqu'un va mystérieusement disparaitre
        /// </summary>
        /// <param name="passagers">passagers à mettre dans l'avion. (pas besoin de les mettre en ordre</param>
        public void Remplir(Passager[] passagers)
        {
            Array.Sort(passagers);
            foreach (Passager passager in passagers)
            {
                Sections[passager.Numero].AjouterPassager(passager);
            }
        }
        /// <summary>
        /// décharge l'avion
        /// </summary>
        /// <returns>Les passagers sortis de l'avion</returns>
        public List<Passager> Decharcher()
        {
            List<Passager> output = new List<Passager>();


            for (int i = Sections.Length-1; i > -1; i--) 
            {
                output.AddRange(Sections[i].DechargerPassagers());
            }


            return output;
        }



        /// <summary>
        /// ToString de l'avion pour qu'il soit lisible
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = "   ___________\n";
            //                  ___________
            for (int i = 0; i < Sections.Length; i++)
            {
                output += Sections[i].ToString(i)+"\n";
            }
            output += "   -----------";
            //           -¯¯¯¯¯¯¯¯¯¯¯

            return output;
        }


        #region get/set
        /// <summary>
        /// nom du pilote de l'avion
        /// </summary>
        public string Pilote        { get => _pilote;       private set => _pilote = value; }
        /// <summary>
        /// nom du copilote de l'avion
        /// </summary>
        public string Copilote      { get => _copilote;     private set => _copilote = value; }
        /// <summary>
        /// noms des agents de bords
        /// </summary>
        public string[] AgentsDeBord{ get => _agentsDeBord; private set => _agentsDeBord = value; }
        /// <summary>
        /// Sections de l'avion
        /// </summary>
        public Section[] Sections   { get => _sections;     private set => _sections = value; }
        #endregion
    }
}
