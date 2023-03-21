/*  Dans la classe Program créer :

Le stock sous forme d'une collection d’articles de votre choix. */

namespace ArticleCs
{
    public class Program
    {
    // private static Stock stock = new Stock();
        public static void Main(String[] args)
        {
        int retour = 0;

            while (retour != 8)
            {
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1) Rechercher un article par référence");
                Console.WriteLine("2) Ajouter un article au stock en vérifiant l’unicité de la référence");
                Console.WriteLine("3) Supprimer un article par référence");
                Console.WriteLine("4) Modifier un article par référence");
                Console.WriteLine("5) Rechercher un article par nom");
                Console.WriteLine("6) Rechercher un article par intervalle de prix de vente");
                Console.WriteLine("7) Afficher tous les articlese");

                Console.WriteLine("8) Quitter");
                retour = Int32.Parse(Console.ReadLine());

                switch (retour)
                {
                    case 1:
                        // Stock.RechercheParRef();
                        break;

                    case 2:
                        saisirArticle();
                        break;

                    case 3:
                        // Stock.Supprimer();
                        break;

                    case 4:
                        // Stock.Modifier();
                        break;

                    case 5:
                        // Stock.RechercheParNom();
                        break;

                    case 6:
                        
                        break;

                    case 7:
                        // Stock.AfficherArticles();
                        break;

                    default:
                        break;
                }
            }
        }

        public static void saisirArticle()
        {
                Article article = new Article();

                Console.WriteLine("Nom de l'article : ");
                article.Nom = Console.ReadLine();
                Console.WriteLine("Reference : ");
                article.Reference = Console.ReadLine();
                Console.WriteLine("Prix : ");
                article.Prix = Console.ReadLine();
                Console.WriteLine("nombre d'article : ");
                article.Quantite = Console.ReadLine();

            if(Stock.TrouverRef(article))
            {
                Console.WriteLine("Cet ref existe déjà");
            } else {
                Stock.Ajouter(article);
            }
        }
    }
}