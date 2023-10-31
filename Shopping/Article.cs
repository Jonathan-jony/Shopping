<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Shopping
=======
﻿namespace Shopping
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
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
<<<<<<< HEAD
            _id = id;
            _description = description;
            _price = price;
        }


=======
            throw new NotImplementedException();
        }

>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        public int Id
        {
            get
            {
<<<<<<< HEAD
                return _id;
=======
                throw new NotImplementedException();
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
            }
        }

        public string Description
        {
            get
            {
<<<<<<< HEAD
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
=======
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
            }
        }

        public float Price
        {
            get
            {
<<<<<<< HEAD
                return _price;
=======
                throw new NotImplementedException();
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
            }
        }
        #endregion public methods

        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
