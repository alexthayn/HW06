using System;

namespace HW06_AThayn.Model
{
    public class MoonPhase
    {
        DateTime PhaseStart { get; set; }
        string ImagePath { get; set; }

        public MoonPhase(DateTime start, string path)
        {
            PhaseStart = start;
            ImagePath = path;
        }
    }
}
