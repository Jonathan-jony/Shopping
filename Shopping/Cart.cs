using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems = cartItems;
        }

        public List<CartItem> Remove(Boolean clearCart = false)
        {

            throw new NotImplementedException();
        }

        public List<CartItem> Remove(CartItem cartItemToRemove)
        {
            throw new NotImplementedException();
        }

        public void Release()
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
                return (float)_price;
            }
        }

        public bool? IsReleased { get; set; }
        #endregion public methods
    }
}
