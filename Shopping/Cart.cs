using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        private float _price = 0;
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems = cartItems;
        }

        public void Remove(List<CartItem> cartItemsToRemove)
        {
            throw new NotImplementedException();
        }
        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public float Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion public methods
    }
}
