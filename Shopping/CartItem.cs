<<<<<<< HEAD
﻿using System.Net.Http.Headers;

namespace Shopping
=======
﻿namespace Shopping
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
{
    public class CartItem
    {
        #region private attributes
        private Article? _article = null;
        private int _quantity = 0;
        #endregion private attributes

        #region public methods
        public CartItem(Article article, int quantity)
        {
<<<<<<< HEAD
            _quantity = quantity;
            for (int i = 0; i < _quantity; i++)
            {
                _article = article;
            }
=======
            throw new NotImplementedException();
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        }

        public Article Article
        {
            get
            {
<<<<<<< HEAD
                return _article;
=======
                throw new NotImplementedException();
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
            }
        }

        public int Quantity
        {
            get
            {
<<<<<<< HEAD
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new WrongQuantityException();
                }
                _quantity = value;
=======
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
            }
        }
        #endregion public methods

        public class CartItemException : Exception { }
        public class WrongQuantityException : CartItemException { }
    }
}
