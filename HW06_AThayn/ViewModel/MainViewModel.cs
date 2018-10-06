using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW06_AThayn.Model;

namespace HW06_AThayn.ViewModel
{
    public class MainViewModel
    {
        //List of moon phases to add to the calendar
        ObservableCollection<MoonPhase> MoonPhaseList;

        //Image path that is bound to
        public string ImagePath { get; set; }

        public MainViewModel()
        {
            MoonPhaseList = new ObservableCollection<MoonPhase>();

            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,01,01), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,01,08), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,01,16), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,01,24), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,01,31), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,02,07), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,02,15), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,02,23), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,03,01), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,03,09), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,03,17), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,03,24), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,03,31), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,04,08), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,04,15), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,04,22), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,04,29), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,05,07), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,05,15), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,05,21), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,05,29), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,06,06), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,06,13), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,06,20), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,06,27), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,07,06), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,07,12), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,07,19), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,07,27), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,08,04), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,08,11), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,08,18), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,08,26), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,09,02), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,09,09), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,09,16), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,09,24), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,10,02), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,10,08), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,10,16), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,10,24), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,10,31), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,11,07), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,11,15), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,11,22), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,11,29), "/Images/4.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,12,07), "/Images/1.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,12,15), "/Images/2.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,12,22), "/Images/3.jpg"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018,12,29), "/Images/4.jpg"));
        }
    }
}
