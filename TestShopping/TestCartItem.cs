using Shopping;
using static Shopping.CartItem;

namespace TestShopping
{
    public class TestCartItem
    {
        #region private attributes
        private CartItem? _cartItem = null;
<<<<<<< HEAD
        private Article? _article = null;
=======
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        private float _price = 0f;
        private int _quantity = 0;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            List<Article> articles = ArticleGenerator.Generate(1);
            _quantity = 1;
            _cartItem = new CartItem(articles[0], _quantity);
        }

        [Test]
        public void AllProperties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup
            _price = 2.0f;

            //when
            //Event will be triggered by constructor

            //then
<<<<<<< HEAD
            Assert.AreEqual(_price, _cartItem.Article.Price);
            Assert.AreEqual(_quantity, _cartItem.Quantity);
=======
            Assert.That(_cartItem.Article.Price, Is.EqualTo(_price));
            Assert.That(_cartItem.Quantity, Is.EqualTo(_quantity));
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        }

        [Test]
        public void SetQuantity_CorrectValue_GetNewValue()
        {
            //given
            int expectedQuantity = 2;

            //when
            _cartItem.Quantity = expectedQuantity;

            //then
<<<<<<< HEAD
            Assert.AreEqual(_cartItem.Quantity, expectedQuantity);
=======
            Assert.That(expectedQuantity, Is.EqualTo(_cartItem.Quantity));
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        }

        [Test]
        public void SetQuantity_WrongValue_ThrowException()
        {
            //given
            int expectedQuantity = -2;

            //when
            Assert.Throws<WrongQuantityException>(() => _cartItem.Quantity = expectedQuantity);
            
            //then
            //throws exception
        }
    }
}