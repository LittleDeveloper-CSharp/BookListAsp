using Xunit;

namespace Test
{
    public class Tests
    {
        private BookListAsp.Models.WorkWithAuthor bookController;
        private BookListAsp.Models.WorkWithBook authorController;
        private BookListAsp.Models.WorkWithGenre genreController;
        public Tests()
        {
            bookController = new BookListAsp.Models.WorkWithAuthor();
            authorController = new BookListAsp.Models.WorkWithBook();
            genreController = new BookListAsp.Models.WorkWithGenre();
        }

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {

        }
        [Fact]
        public void Test3()
        {

        }
    }
}