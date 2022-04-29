using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;

namespace ApplicationTemplate.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class FileService : IFileService
{
    private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config")
        .GetCurrentClassLogger();

    public string movieFilePath { get; set; }
    public string showFilePath { get; set; }
    public string videoFilePath { get; set; }


    public List<Movie> Movies { get; set; }

    public List<Show> Shows { get; set; }

    public List<Video> Videos { get; set; }



    public FileService()
    {
        movieFilePath = "files/movies.csv";
        Movies = new List<Movie>();
        showFilePath = "files/Shows.csv";
        Shows = new List<Show>();
        videoFilePath = "files/videos.csv";
        Videos = new List<Video>();


        try
        {
            StreamReader sr = new StreamReader(movieFilePath);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                
                Movie movie = new Movie();
                string line = sr.ReadLine();
                
                int idx = line.IndexOf('"');
                if (idx == -1)
                {
                    
                    string[] movieDetails = line.Split(',');
                    movie.mediaId = UInt64.Parse(movieDetails[0]);
                    movie.Title = movieDetails[1];
                    movie.Genres = movieDetails[2].Split('|').ToList();

                }

                Movies.Add(movie);
            }

            sr.Close();


            sr = new StreamReader(showFilePath);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                
                Show show = new Show();
                string line = sr.ReadLine();
                
                int idx = line.IndexOf('"');
                if (idx == -1)
                {
                    
                    string[] movieDetails = line.Split(',');
                    show.mediaId = UInt64.Parse(movieDetails[0]);
                    show.Title = movieDetails[1];
                    show.Season = UInt64.Parse(movieDetails[2]);
                    show.Episode = UInt64.Parse(movieDetails[3]);
                    show.Writers = movieDetails[4].Split('|').ToList();
                    show.Format = movieDetails[5];


                }

                Shows.Add(show);
            }
            sr.Close ();

            sr = new StreamReader(videoFilePath);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                
                Video video = new Video();
                string line = sr.ReadLine();
                
                int idx = line.IndexOf('"');
                if (idx == -1)
                {
                    
                    string[] movieDetails = line.Split(',');
                    video.mediaId = UInt64.Parse(movieDetails[0]);
                    video.Title = movieDetails[1];
                    video.Format = movieDetails[2];
                    video.Duration = TimeSpan.Parse(movieDetails[3]);
                    video.Regions = movieDetails[4].Split('|').ToList();
                    video.Genres = movieDetails[5].Split('|').ToList();
                    

                }

                Videos.Add(video);
            }


            logger.Info("Movies in file", Movies.Count);
        }
        catch (Exception ex)
        {
            logger.Error(ex.Message);
        }
    }




}


