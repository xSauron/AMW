using System;
using Xunit;

namespace Cinema.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Movie_IsCreated_WithCorrectProperties()
        {
            // Arrange
            string title = "The Shawshank";
            Genre genre = Genre.Drama;
            int rating = 5;

            // Act
            Movie movie = new Movie(title, genre, rating);

            // Assert
            Assert.Equal(title, movie.Title);
            Assert.Equal(genre, movie.Genre);
            Assert.Equal(rating, movie.Rating);
        }

        [Theory]
        [InlineData("Action", Genre.Action)]
        [InlineData("Adventure", Genre.Adventure)]
        [InlineData("Comedy", Genre.Comedy)]
        [InlineData("Drama", Genre.Drama)]
        [InlineData("Fantasy", Genre.Fantasy)]
        [InlineData("Horror", Genre.Horror)]
        [InlineData("Mystery", Genre.Mystery)]
        [InlineData("Romance", Genre.Romance)]
        [InlineData("Thriller", Genre.Thriller)]
        public void Movie_CanBeCreated_WithAllGenres(string genreName, Genre genre)
        {
            // Arrange
            string title = "Movie";
            int rating = 5;

            // Act
            Movie movie = new Movie(title, genre, rating);

            // Assert
            Assert.Equal(genre, movie.Genre);
        }

        [Fact]
        public void Movie_CanBeCreated_WithValidRating()
        {
            // Arrange
            string title = "Movie";
            Genre genre = Genre.Action;
            int rating = 3;

            // Act
            Movie movie = new Movie(title, genre, rating);

            // Assert
            Assert.Equal(title, movie.Title);
            Assert.Equal(genre, movie.Genre);
            Assert.Equal(rating, movie.Rating);
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(6)]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void Movie_ConstructorThrowsException_ForInvalidRating(int rating)
        {
            // Arrange
            string title = "Movie";
            Genre genre = Genre.Action;

            // Act
            Action act = () => new Movie(title, genre, rating);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}