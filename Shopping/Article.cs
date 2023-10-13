using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

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
                Regex regex = new Regex("[^a-zA-Z0-9 ]");
                _description = value;
                
                if(_description.Length > 50) 
                {
                    throw new TooLongDescriptionException();
                }
                else if (regex.IsMatch(_description))
                {
                    throw new SpecialCharInDescriptionException();
                }
                else if (!_description.Contains(" "))
                {
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
