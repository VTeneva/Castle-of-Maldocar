using System;
using System.Media;

namespace _01.Game_Frame
{
    public class Music
   {
        public Music()
        {
            this.Play();
        }

        public void Play()
        {
            using(SoundPlayer sound = new SoundPlayer("../../theme_music.wav"))
            {
                sound.PlayLooping();
            }
        }

        public void Stop()
        {
            using (SoundPlayer sound = new SoundPlayer("../../theme_music.wav"))
            {
                sound.Stop();
            }
        }

        private static string MusicTheme = "../../theme_music.wav";
    }
}
