namespace ArticleCs
{
    public class Stock
    {
        // ***  ATTRIBUTS *** //
        public List<Article> Articles { get; set; }


        // ***  CONSTRUCTEUR *** //
        public Stock(string nom, string reference, float prix, int quantite)
        {
            Articles = new List<Article>();
        }


        // ***  MÉTHODES *** //
        public void Ajouter(Article article) // Ajoute un article
        {
            Articles.Add(article);
        }
   
        public void Supprimer(Article article) // Supprime un article
        {
            Articles.Remove(article);
        }

        // public void Modifier(Article article) // Modifie un article
        // {
        //     Article.Update(article);
        // }

        public Article RechercheParRef(Article reference) // Recherche un article par REF
        {
            foreach(Article article in this.Articles)
            {
                if (Article.nom == article)
                {
                    return Articles;
                }
            }
            return null; // Si l'article n'est pas trouvé
            }
    
        public Article RechercheParNom(string nom) // Recherche par nom
        {
            foreach(Article articles in List<Article>)
            {
                if (article.nom == nom)
                {
                    return article;
                }
            }
            return null; // Si l'article n'est pas trouvé
            }

        public bool TrouverRef(string artATrouver)
        {
            foreach(Article article in this.Articles)
            {
                article.reference == artATrouver.reference;
            }
            return false;
        } 
        public List<Article> AfficherArticles() // Afficher tous les articles
        {
            List<Article> listeArticle = new List<Article>();
            return listeArticle;
        }
    
    
    }
}