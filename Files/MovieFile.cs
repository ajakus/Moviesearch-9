namespace ApplicationTemplate.Services;

public class MovieFile
{
/*    string Movfile = "movies.csv";

    StreamReader sr = new StreamReader(Movfile);






    public void ReadMovie()
    {
        StreamReader sr = new StreamReader(Moviefile);

        string line = sr.ReadLine();

        while (!sr.EndOfStream)
        {
            line = sr.ReadLine();
            var column = line.Split(',');
            var sv = string.Join(',', column);
            Console.WriteLine(sv);

        }
        sr.Close();

    }
    public void WriteMovie()
    {
        Console.WriteLine("What is movie ID ?");
        var movieID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the movie title ?");
        var movieTitle = Console.ReadLine();

        Console.WriteLine("How many genres ?");
        var genreNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the genre ?");
        string[] genreAr = new string[genreNum];

        //loop for multiple genres
        for (int i = 0; i < genreNum; i++)
        {
            Console.WriteLine("Genre (" + (i + 1) + ")");
            var movieGenre = Console.ReadLine();
            genreAr[i] = movieGenre;


        }

        var ss = string.Join('|', genreAr);
        var se = string.Join(',', movieID, movieTitle, ss);

        StreamWriter sw = new StreamWriter(Moviefile, append: true);
        var dataLine = (se);
        sw.WriteLineAsync(dataLine);
        sw.Close();
    }
}

string Showfile = "shows.csv";

public void ReadShow()
{
    StreamReader sr = new StreamReader(Showfile);

    string line = sr.ReadLine();

    while (!sr.EndOfStream)
    {
        line = sr.ReadLine();
        var column = line.Split(',');
        var sv = string.Join(',', column);
        Console.WriteLine(sv);

    }
    sr.Close();
}
public void WriteShow()
{
    Console.WriteLine("What is Show ID ?");
    var movieID = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What is the Show title ?");
    var movieTitle = Console.ReadLine();

    Console.WriteLine("What Season is the Show on ?");
    var season = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What Epsiode is the Show on ?");
    var episode = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("How many writers does the show have ?");
    var ShowFNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What format is it in ? *EX: DVD or VHS or Online*");
    string[] ShowFAr = new string[ShowFNum];


    //loop for multiple writers
    for (int i = 0; i < ShowFNum; i++)
    {
        Console.WriteLine("Writer (" + (i + 1) + ")");
        var movieWriters = Console.ReadLine();
        ShowFAr[i] = movieWriters;

    }

    var sd = string.Join('|', ShowFAr);

    var se = string.Join(',', movieID, movieTitle, season, episode, sd);

    StreamWriter sw = new StreamWriter(Showfile, append: true);
    var dataLine = (se);
    sw.WriteLineAsync(dataLine);
    sw.Close();


}

string Videofile = "videos.csv";

public void ReadVideo()
{
    StreamReader sr = new StreamReader(Videofile);

    string line = sr.ReadLine();

    while (!sr.EndOfStream)
    {
        line = sr.ReadLine();
        var column = line.Split(',');
        var sv = string.Join(',', column);
        Console.WriteLine(sv);

    }
    sr.Close();
}
public void WriteVideo()
{
    Console.WriteLine("What is Video ID ?");
    var movieID = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What is the Video title ?");
    var movieTitle = Console.ReadLine();

    Console.WriteLine("How many places is the Video viewable ?");
    var VidFNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What format is it in ? *EX: DVD or VHS or Online*");
    string[] vidFAr = new string[VidFNum];


    //loop for multiple formats
    for (int i = 0; i < VidFNum; i++)
    {
        Console.WriteLine("Format (" + (i + 1) + ")");
        var movieFormat = Console.ReadLine();
        vidFAr[i] = movieFormat;

    }

    Console.WriteLine("What is the Video length ?");
    var movieLength = Console.ReadLine();

    Console.WriteLine("How many places is the Video viewable ?");
    var VidNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What is the genre ?");
    string[] vidAr = new string[VidNum];


    //loop for multiple regions
    for (int i = 0; i < VidNum; i++)
    {
        Console.WriteLine("Regions (" + (i + 1) + ")");
        var movieRegions = Console.ReadLine();
        vidAr[i] = movieRegions;

    }

    var sd = string.Join('|', vidFAr);
    var ss = string.Join('|', vidAr);
    var se = string.Join(',', movieID, movieTitle, sd, movieLength, ss);

    StreamWriter sw = new StreamWriter(Videofile, append: true);
    var dataLine = (se);
    sw.WriteLineAsync(dataLine);
    sw.Close();

}*/
}
