namespace Shopping
{
    public class Checkout : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private float _balance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            int i = 0;
            i++;
            _balance = i;
            _articles = articles;
        }

        public List<Article> Remove(Boolean empty = false)
        {
            List<Article> actualArticles = new List<Article>();
            if (empty)
            {
                for (int i = 0; i <= _articles.Count; i++)
                {
                    actualArticles.Add(new Article(i));
                }
                _articles.Clear();
                return _articles;
            }
            else
            {
                _articles.RemoveAt(_articles.Count - 1);
                for (int i = 9; i <= _articles.Count; i++)
                {
                    actualArticles.Add(new Article(i));
                }
                return actualArticles;
            }
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public float Balance
        {
            get
            {
                return (float)_balance;
            }
        }

        public void StartCashingProcess()
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                throw new NotImplementedException();
            }
        }
        #endregion private methods
    }
}
