namespace Biblio
{
    public class Banc
    {
        public enum TypeEnum {
            Premiere = 0,
            Reguliere = 1,
            Economique = 2
        }

        private TypeEnum _type;

        private Passager _passager = null;

        public Banc(TypeEnum type)
        {
            Type = type;
        }

        public override string ToString()
        {
            string output = "";


            if (Passager is not null) { output = Passager.Nom.Substring(0, 1); }
            else output = "_";

            return output;
        }


        public TypeEnum Type { get => _type; private set => _type = value; }
        public Passager Passager { get => _passager; set => _passager = value; }
    }
}