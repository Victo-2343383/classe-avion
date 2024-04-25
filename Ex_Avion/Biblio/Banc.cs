namespace Biblio
{
    public class Banc
    {
        enum TypeEnum {
            Premiere = 0,
            Reguliere = 1,
            Economique = 2
        }

        private TypeEnum _type;

        private Passager _passager = null;
    }
}