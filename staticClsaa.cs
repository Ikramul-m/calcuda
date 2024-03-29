using System;

class Song
{
    public string title;
    public string artist;
    public int duration;

    public Song(string aTitle, string aArtist, int aDuration)
    {
        title = aTitle;
        artist = aArtist;
        duration = aDuration;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Song holiday = new Song("Holiday", "Green Day", 200);
        Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

        Console.WriteLine(holiday.artist);
        Console.WriteLine(kashmir.artist);
    }
}



