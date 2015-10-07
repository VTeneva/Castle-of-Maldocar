using System;
using System.Media;

namespace _01.Game_Frame
{
    public class Music
   {
       public static string MusicTheme = "../../theme_music.wav";
       public static string VictoryTheme = "../../victory.wav";

        public Music()
        {
            //this.Play(MusicTheme);
        }

        public void Play(string musicToPlay)
        {
            using (SoundPlayer sound = new SoundPlayer(musicToPlay))
            {
                sound.PlayLooping();
            }
        }

        public void Stop(string musicToPlay)
        {
            using (SoundPlayer sound = new SoundPlayer(musicToPlay))
            {
                sound.Stop();
            }
        }

    }
}
