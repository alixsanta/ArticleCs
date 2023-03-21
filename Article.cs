/*
Créer la classe article contenant les éléments suivants :

Les attributs/propriétés -- Un constructeur -- La méthode ToString(). */

namespace ArticleCs
{
    public class Article
    {

        // ***** ATTRIBUTS ***** //
        private string Nom {get; set;}
        private string Reference {get; set;}
        private float Prix {get; set;}
        private int Quantite {get; set;}


        public Article(string nom, string reference, float prix, int quantite)
        {
            Nom = nom;
            Reference = reference;
            Prix = prix;
            Quantite = quantite;
        }


        // ***** MÉTHODES ***** //
        // public override string ToString()
        // {

        // }
    }


}