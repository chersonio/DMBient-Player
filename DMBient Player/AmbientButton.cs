using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMBient_Player
{
    public class AmbientButton
    {

        // to kathe koumpi tha exei kapoio Volume, icon, ixitiko, timers, xrwma

        public int Volume { get; set; } = 0;
        public string FilePath { get; set; } // file path of mp3
        
        public bool Repeat { get; set; } = false;// time intervals- every 5 seconds the sound will be played
        public double Start { get; set; } = 0; // this will declare the begining of a sound
        public double Finish { get; set; } = 0; // this will declare the end of a sound. 
        public double FadeIn { get; set; } = 0; // this will declare the begining of volume increase
        public double FadeOut { get; set; } = 0; // this will declare the begining of volume decrease

        public string Icon { get; set; } = null; // tha einai string path enos iconidiou

    }
}
