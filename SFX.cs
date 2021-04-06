using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGussingGame
{
  public static class SFX
    {
        public static string [] SoundEffects = new string[4];
        static SoundPlayer sound = new SoundPlayer();
        public static void InstantiateSound()
        {
            SoundEffects[0] = "SoundSFX/Click_01.wav";
            SoundEffects[1] = "SoundSFX/Click_02.wav";
            SoundEffects[2] = "SoundSFX/Select_01.wav";
            SoundEffects[3] = "SoundSFX/Victory_Sound.wav";
        }

        public static void PlaySound(string music)
        {
            sound.SoundLocation = music;
            sound.Play();
        }


    }
}
