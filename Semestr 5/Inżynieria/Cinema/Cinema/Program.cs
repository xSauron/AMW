using System;
using System.Collections.Generic;

namespace Cinema
{
    public class Program
    {
        static void Main() { }
    }
    public enum Genre
    {
        Action,
        Adventure,
        Comedy,
        Drama,
        Fantasy,
        Horror,
        Mystery,
        Romance,
        Thriller
    }

    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;
            if (rating < 1 || rating > 5)
            {
                throw new ArgumentOutOfRangeException("Rating must be between 1 and 5.");
            }
            Rating = rating;
        }
    }

    public class Review
    {
        public Movie Movie { get; set; }
        public string Reviewer { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }

        public Review(Movie movie, string reviewer, string reviewText, int rating)
        {
            Movie = movie;
            Reviewer = reviewer;
            ReviewText = reviewText;
            if (rating < 1 || rating > 5)
            {
                throw new ArgumentOutOfRangeException("Rating must be between 1 and 5.");
            }
            Rating = rating;
        }
    }

    public class Room
    {
        public int Number { get; set; }
        public int Capacity { get; set; }
        public List<Movie> Showings { get; set; }

        public Room(int number, int capacity, List<Movie> showings)
        {
            Number = number;
            if (capacity > 0 )
            {
                throw new ArgumentOutOfRangeException("Capacity must be above 0.");
            }
            Capacity = capacity;
            Showings = showings;
        }
    }

    public class Cinema
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Room> Rooms { get; set; }

        public Cinema(string name, List<Movie> movies, List<Review> reviews, List<Room> rooms)
        {
            Name = name;
            Movies = movies;
            Reviews = reviews;
            Rooms = rooms;
        }
    }

    public class Showtime
    {
        public Movie Movie { get; set; }
        public Room Room { get; set; }
        public DateTime StartTime { get; set; }

        public Showtime(Movie movie, Room room, DateTime startTime)
        {
            Movie = movie;
            Room = room;
            StartTime = startTime;
        }
    }

    public class Ticket
    {
        private Showtime Showtime;

        private decimal Price { get; set; }

        public Ticket(Showtime showtime, decimal price)
        {
            Showtime = showtime;
            Price = price;
        }

    }

    public class Customer
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string name, string emailAddress, string phoneNumber)
        {
            Name = name;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }
    }

    public class Booking
    {
        public Movie Movie { get; private set; }
        public Room Room { get; private set; }
        public DateTime ShowingDate { get; private set; }
        public int NumberOfTickets { get; private set; }
        public decimal TotalCost { get; private set; }
        public Customer Customer { get; private set; }
        public Ticket Ticket { get; private set; }

        public Booking(Movie movie, Room room, DateTime showingDate, int numberOfTickets, Customer customer, Ticket ticket)
        {
            Movie = movie;
            Room = room;
            ShowingDate = showingDate;
            NumberOfTickets = numberOfTickets;
            TotalCost = ticket.Price * numberOfTickets;
            Customer = customer;
        }
    }
}