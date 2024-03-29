using System;

class Song
{
    public string title;
    public string artist;
    public int duration;
    public static int songCount = 0;

    public Song(string aTitle, string aArtist, int aDuration)
    {
        title = aTitle;
        artist = aArtist;
        duration = aDuration;
        songCount++;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Song holiday = new Song("Holiday", "Green Day", 200);
        Console.Write(Song.songCount);
        Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
        Console.Write(Song.songCount);
    }
}



