namespace Biblio
{
    public class Banc
    {
        /// <summary>
        /// Première classe contient seulement 4 sièges par section. 
        /// Regulière et économique contiennent 6 sièges par section.
        /// </summary>
        public enum TypeEnum {
            Premiere = 0,
            Reguliere = 1,
            Economique = 2
        }

        private TypeEnum _type;

        private Passager _passager = null;

        /// <summary>
        /// constructeur d'un banc
        /// </summary>
        /// <param name="type"></param>
        public Banc(TypeEnum type)
        {
            Type = type;
        }

        /// <summary>
        /// vide le banc et retourne le passager
        /// </summary>
        /// <returns></returns>
        public Passager Vider()
        {
            if (Passager == null) return null;


            Passager output = new Passager(Passager.Nom, Passager.Lettre, Passager.Numero, Passager.Naissance);
            Passager = null;
            return output;
        }

        public void Ajouter(Passager passager)
        {
            Passager = passager;
        }

        /// <summary>
        /// ToString du banc.
        /// </summary>
        /// <returns>Retourne la prenière lettre du nom du passager, retourne un '_' si le siège est vide</returns>
        public override string ToString()
        {
            string output = "";

            if (Passager is not null) { output = Passager.Nom.Substring(0, 1); }
            else output = "_";

            return output;
        }

        /// <summary>
        /// type du siège
        /// </summary>
        public TypeEnum Type { get => _type; private set => _type = value; }
        /// <summary>
        /// passager sur le siège.
        /// </summary>
        public Passager Passager { 
            get => _passager;
            private set
            {
                _passager = value;
            }
        }
    }
}