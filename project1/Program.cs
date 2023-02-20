
using System;

namespace MP3Tracker
{



    public enum Genre
    {
        Rock,
        Pop,
        Jazz,
        Country,
        Classical,
        Other
    }

    public class MP3
    {
        public string SongTitle { get; set; }
        public string Artist { get; set; }
        public string SongReleaseDate { get; set; }
        public double PlaybackTime { get; set; }
        public Genre Genre { get; set; }
        public decimal DownloadCost { get; set; }
        public double FileSize { get; set; }
        public string AlbumCoverPath { get; set; }

        public MP3()
        {
        }

        public MP3(string songTitle, string artist, string releaseDate, double playbackTime, Genre genre, decimal downloadCost, double fileSize, string albumCoverPath)
        {
            SongTitle = songTitle;
            Artist = artist;
            SongReleaseDate = releaseDate;
            PlaybackTime = playbackTime;
            Genre = genre;
            DownloadCost = downloadCost;
            FileSize = fileSize;
            AlbumCoverPath = albumCoverPath;
        }

        public override string ToString()
        {
            return string.Format("Song Title: {0}\nArtist: {1}\nRelease Date: {2}\nPlayback Time: {3} minutes\nGenre: {4}\nDownload Cost: ${5}\nFile Size: {6} MB\nAlbum Cover Path: {7}",
                SongTitle, Artist, SongReleaseDate, PlaybackTime, Genre, DownloadCost, FileSize, AlbumCoverPath);
        }
    }
}