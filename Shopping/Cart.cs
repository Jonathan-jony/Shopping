<<<<<<< HEAD
﻿using System;
using System.Net.Http.Headers;

namespace Shopping
=======
﻿namespace Shopping
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
<<<<<<< HEAD
        private float _price = 0;
=======
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
<<<<<<< HEAD
            _cartItems = cartItems;
        }

        public void Remove(List<CartItem> cartItemsToRemove = null)
        {
            throw new NotImplementedException();
        }
=======
            throw new NotImplementedException();
        }

        public void Remove(List<CartItem> cartItemsToRemove)
        {
            throw new NotImplementedException();
        }

>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        public List<CartItem> CartItems
        {
            get
            {
<<<<<<< HEAD
                return _cartItems;
            }
        }

        public float Price
        {
            get
            {
                float currentCartPrice = 0f;
                foreach (var item in _cartItems)
                {
                    currentCartPrice += item.Article.Price * item.Quantity;
                }
                return currentCartPrice;
            }
=======
                throw new NotImplementedException();
            }
        }

        public float Price(bool average = false)
        {
            throw new NotImplementedException();
        }

        public bool DoesExist(int articleId)
        {
            throw new NotImplementedException();
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        }

        public int Cheapest()
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD
        #endregion public methods
        public class CartException : Exception { }
=======

        public int MostExpensive()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
    }
}
