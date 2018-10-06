using System;

namespace HW06_AThayn.Model
{
    public class MoonPhase
    {
        public DateTime PhaseStart { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }

        public MoonPhase(DateTime start, string path, string description)
        {
            PhaseStart = start;
            ImagePath = path;
            Description = description;
        }
    }
}
