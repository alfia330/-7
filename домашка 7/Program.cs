using System;

class Song
{
    string name;
    string author;
    Song prev;

    public void SetName(string n) { name = n; }
    public void SetAuthor(string a) { author = a; }
    public void SetPrev(Song p) { prev = p; }

    public string Title()
    {
        return name + " — " + author;
    }

    public override bool Equals(object d)
    {
        if (d is Song other)
            return this.name == other.name && this.author == other.author;
        return false;
    }
}

class Program
{
    static void Main()
    {
        Song[] songs = new Song[4];
        for (int i = 0; i < 4; i++)
        {
            songs[i] = new Song();
            songs[i].SetName("Песня " + (i + 1));
            songs[i].SetAuthor("Автор " + (i + 1));
            if (i > 0) songs[i].SetPrev(songs[i - 1]);
        }

        Console.WriteLine("Список песен:");
        foreach (Song s in songs)
            Console.WriteLine(s.Title());

        Console.WriteLine("\nСравнение первой и второй: " + songs[0].Equals(songs[1]));

        
        Song copy = new Song();
        copy.SetName("Песня 1");
        copy.SetAuthor("Автор 1");
        Console.WriteLine("Первая == копия первой: " + songs[0].Equals(copy));
    }
}