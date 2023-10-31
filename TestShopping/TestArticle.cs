using Shopping;
using static Shopping.Article;
using static Shopping.CartItem;

namespace TestShopping
{
    public class TestArticle
    {
        #region private attributes
        private Article? _article = null;
        private int _id;
        private string _description;
        private float _price = 0f;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _id = 1;
            _description = "product description";
            _price = 20.45f;
            _article = new Article(_id, _description, _price);
        }

        [Test]
        public void AllProperties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup

            //when
            //Event will be triggered by constructor

            //then
<<<<<<< HEAD
            Assert.AreEqual(_id, _article.Id);
            Assert.AreEqual(_description, _article.Description);
            Assert.AreEqual(_price, _article.Price);
=======
            Assert.That(_article.Id, Is.EqualTo(_id));
            Assert.That(_article.Description, Is.EqualTo(_description));
            Assert.That(_article.Price, Is.EqualTo(_price));
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        }

        #region Description
        /*
         * A article description must meet theses specifications:
         *  * 2 words minimum
         *  * No special chars like {!,*,+,/}
         *  * Max 50 chars (blank spaces count)
         */

        [Test]
<<<<<<< HEAD
        public void Description_CorrectDescription_ReturnNewValue()
=======
        public void Description_ShortDescription_ReturnNewValue()
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        {
            //given
            string expectedDescription = "After Shave";

            //when
            _article.Description = expectedDescription;

            //then
<<<<<<< HEAD
            Assert.AreEqual(expectedDescription, _article.Description);
=======
            Assert.That(_article.Description, Is.EqualTo(expectedDescription));
        }

        [Test]
        public void Description_LongDescription_ReturnNewValue()
        {
            //given
            string expectedDescription = "A very long long long long long long descriptionn";

            //when
            _article.Description = expectedDescription;

            //then
            Assert.That(_article.Description, Is.EqualTo(expectedDescription));
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
        }

        [Test]
        public void Description_SingleWordDescription_ThrowException()
        {
            //given

            //when
            Assert.Throws<TooShortDescriptionException>(() => _article.Description = "TooShort");

            //then
            //throws exception
        }

        [Test]
        public void Description_DescriptionContainingSpecialChars_ThrowException()
        {
            //given

            //when
            Assert.Throws<SpecialCharInDescriptionException>(() => _article.Description = "Jacques+Daniel");

            //then
            //throws exception
        }

        [Test]
        public void Description_TooLongDescription_ThrowException()
        {
            //given

            //when
            Assert.Throws<TooLongDescriptionException>(() => _article.Description = "A very very very very very looonnng descriptioooooon");

            //then
            //throws exception
        }
        #endregion Description
    }
}