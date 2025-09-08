using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_07
{
    public interface IMusicApplication
    {
        public void PlayMusic(string songName);
    }
    public class Spotify : IMusicApplication
    {
        public void PlayMusic(string songName)
        {
            Console.WriteLine($"Playing {songName} from Spotify!");
        }
    }
    public class YTMusic : IMusicApplication
    {
        public void PlayMusic(string songName)
        {
            Console.WriteLine($"Playing {songName} from YTMusic!");
        }
    }
    public class MusicPlayer
    {
        private readonly IMusicApplication _musicApplication;
        public MusicPlayer(IMusicApplication musicApplication)
        {
            _musicApplication = musicApplication;
        }
        public void Play(string songName)
        {
            _musicApplication.PlayMusic(songName);
        }
    }
}
