using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    class AudioSound
    {
        int nowsound = 0;

        const int min_sound = 0;
        const int max_sound = 5;

        static public AudioSound Singleton
        {
            get;
            private set;
        }

        static AudioSound()
        {
            Singleton = new AudioSound();
        }

        public int NowSound 
        {
            get 
            {
                return nowsound;
            }

            set 
            {
                if (value < min_sound)
                {
                    nowsound = min_sound;
                }
                else if (value > 5)
                {
                    nowsound = max_sound;
                }
                else 
                {
                    nowsound = value;
                }
            }

        }
    }
}
