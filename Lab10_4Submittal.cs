using System;

namespace Lab10_4Submittal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;

namespace Lab10_4Submittal
{
    class Program
    {

        public static void Main()
        {

            Artist prince = new Artist("Prince");
            prince.AddToPlaylist("Purple Rain");
            prince.AddToPlaylist("Little Red Corvette");
            prince.AddToPlaylist("Kiss");
            prince.AddToPlaylist("When Doves Cry");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(prince);

            AudioBook howto = new AudioBook("How to Win Friends & Influence People", "Dale Carnegie");
            player.PlayMedia(howto);

            MovieSoundTrack starWars = new MovieSoundTrack("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4Submittal
{
    class MovieSoundTrack : IAudioPlayer
    {
        public string movieName { get; }
        public string trackName { get; private set; }

        public MovieSoundTrack(string movieName)
        {
            this.movieName = movieName;
        }

        public void SelectTrack(string track)
        {
            trackName = track;
        }

        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing ");
            sb.Append(movieName);
            sb.Append(" ");
            sb.Append(trackName);
            Console.WriteLine(sb.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4Submittal
{
    class MediaPlayer
    {

        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4Submittal
{
    interface IAudioPlayer
    {
        void Play();
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4Submittal
{
    class AudioBook : IAudioPlayer
    {
        public string bookTitle { get; }
        public string author { get; }

        public AudioBook(string bookTitle, string author)
        {
            this.bookTitle = bookTitle;
            this.author = author;
        }

        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing ");
            sb.Append(bookTitle);
            sb.Append(" by ");
            sb.Append(author);
            Console.WriteLine(sb.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4Submittal
{
    class Artist : IAudioPlayer
    {
        public string artistName { get; }
        public Dictionary<int, string> playlist;


        public Artist(string artistName)
        {
            this.artistName = artistName;
            playlist = new Dictionary<int, string>();
        }

        public void AddToPlaylist(string songTitle)
        {
            int id = playlist.Count;
            playlist.Add(id, songTitle);
        }

        public void Play()
        {
            Random random = new Random();
            int songId = random.Next(0, playlist.Count);
            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing Artist: ");
            sb.Append(artistName);
            sb.Append(" Song: ");
            sb.Append(playlist[songId]);
            Console.WriteLine(sb.ToString());
        }
    }
}


