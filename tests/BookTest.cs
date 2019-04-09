using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace tests
{
    public class BookTest
    {

        [Fact]
        public void ChangePublicationDate()
        {
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);

            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();

            Assert.Equal(expectedPublicationDate, actualPublicationDate);

        }

        [Fact]
        public void ChangeAuthor()
        {
            var book = new Book()
            {
                Id = 2,
                Title = "Domain Driven Designs",
                Author = new Author()
                {
                    Id = 66,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };
            var newAuthor = new Author(){
                Id = 66,
                Name = "Eric Evans2"
            };
            book.ChangeAuthor(newAuthor);

            var expectedAuthorName = "Eric Evans2";
            var actualAuthor = book.Author.Name;

            // Was going to do object comparison but just checked their names instead
            Assert.Equal(expectedAuthorName, actualAuthor);
        }

        [Fact]
        public void CheckAuthor()
        {
            var book = new Book()
            {
                Id = 6,
                Title = "Book with NotNull Author",
                Author = new Author(){ Id = 6, Name = "Jack Moore"},
                PublishDate = DateTime.Now,
                Publisher = "Random Publisher"
            };

            var actualAuthor = book.Author;

            //Checks if Book's author is not null
            Assert.NotNull(book.Author);
        }
    }
}
