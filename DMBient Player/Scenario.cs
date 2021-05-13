using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMBient_Player
{
    public class Scenario
    {

        // Genikotera na uparxoun apothikevmena scenario
        // kathe scenario tha exei kamposa koumpia
        // to kathe koumpi tha exei kapoio Volume, icon, ixitiko, timers, xrwma

        public List<AmbientButton> Buttons { get; set; } = new List<AmbientButton>();

        public string Name { get; set; }


    }
}
