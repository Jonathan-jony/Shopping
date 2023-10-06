using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles = articles;
        }

        public List<Article> Remove(Boolean clearCart = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();
            if (clearCart) 
            {
                for (int i = 0; i <= _articles.Count; i++)
                {
                    articlesReadyToCheckout.Add(new Article(i));
                }
                _articles.Clear();
                return _articles;
            }
            else
            {
                _articles.RemoveAt(_articles.Count - 1);
                for (int i = 9; i <= _articles.Count; i++)
                {
                    articlesReadyToCheckout.Add(new Article(i));
                }
                return articlesReadyToCheckout;               
            }
        }

        public void Release()
        {
            throw new NotImplementedException();
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public bool? IsReleased { get; set; }
        #endregion public methods
    }
}
