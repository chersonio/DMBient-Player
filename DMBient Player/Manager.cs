using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMBient_Player
{
    public enum Theme 
    {
        KirileOnomaGiaTheme, 
        AlloKirileOnomaGiaTheme,
        BloodRoses
    }

    public static class Manager
    {
        public static SettingsManager Settings = SettingsManager.Load();
    }
}
