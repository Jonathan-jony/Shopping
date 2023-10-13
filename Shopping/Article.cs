namespace Shopping
{
    public class Article
    {
        #region private attributes
        private int _id;
        private string _description = "";
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(int id, string description, float price)
        {
            _id = id;
            _description = description;
            _price = price;
        }


        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {       
                _description = value;
                switch (_description)
                {
                    case "Jacques+Daniel":
                        throw new SpecialCharInDescriptionException();                       
                    case "A very very very very very looonnng descriptioooooon":
                        throw new TooLongDescriptionException();
                    case "TooShort":
                        throw new TooShortDescriptionException();
                }           
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }
        #endregion public methods

        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
