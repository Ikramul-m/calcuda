using System;

class Movie
{
    public string name;
    public string director;
    private string rating;

    public Movie(string aName, string aDirector, string aRating)
    {
        name = aName;
        director = aDirector;
        Rating = aRating;
    }

    public string Rating
    {
        get
        {
            return rating;
        }
        set
        {
            if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
            {
                rating = value;
            }
            else
            {
                rating = "NR";
            }
        }
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Movie movie1 = new Movie("Aniaml", "James", "PG");
        Console.Write(movie1.Rating);
    }
}



