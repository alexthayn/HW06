using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HW06_AThayn.Model;

namespace HW06_AThayn.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        //List of moon phases to add to the calendar
        public ObservableCollection<MoonPhase> MoonPhaseList;

        //Image path that is bound to
        private string _imageFromDateSelected;
        public string ImageFromDateSelected
        {
            get
            {
                return _imageFromDateSelected;
            }
            set
            {
                _imageFromDateSelected = value;
                NotifyPropertyChanged(nameof(ImageFromDateSelected));
            }
        }

        //Image scale factor
        private double _scaleFactor;
        public double ScaleFactor
        {
            get
            {
                return _scaleFactor;
            }
            set
            {
                _scaleFactor = value;
                NotifyPropertyChanged(nameof(ScaleFactor));
            }
        }

        //Description of selected date
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                NotifyPropertyChanged(nameof(Description));
            }
        }

        //Selected Date
        private DateTime _dateTime;
        public DateTime SelectedDate
        {
            get
            {
                return _dateTime;
            }
            set
            {
                _dateTime = value;
                NotifyPropertyChanged(nameof(SelectedDate));
                DisplayMoonImageAndDescription();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            MoonPhaseList = new ObservableCollection<MoonPhase>();

            //2018
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 01,01), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 01,08), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 01,16), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 01,24), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 01,31), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 02,07), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 02,15), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 02,23), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 03,01), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 03,09), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 03,17), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 03,24), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 03,31), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 04,08), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 04,15), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 04,22), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 04,29), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 05,07), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 05,15), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 05,21), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 05,29), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 06,06), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 06,13), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 06,20), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 06,28), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 07,06), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 07,12), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 07,19), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 07,27), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 08,04), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 08,11), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 08,18), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 08,26), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 09,02), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 09,09), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 09,16), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 09,24), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 10,02), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 10,08), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 10,16), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 10,24), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 10,31), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 11,07), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 11,15), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 11,23), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 11,29), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 12,07), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 12,15), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 12,22), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2018, 12,29), "/Images/4.jpg", "Last Quarter"));
            //2019
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 01,05), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 01,14), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 01,21), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 01,27), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 02,04), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 02,12), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 02,19), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 02,26), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 03,06), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 03,14), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 03,20), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 03,28), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 04,05), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 04,12), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 04,19), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 04,26), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 05,04), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 05,11), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 05,18), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 05,26), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 06,03), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 06,10), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 06,17), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 06,25), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 07,02), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 07,09), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 07,16), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 07,24), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 07,31), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 08,07), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 08,15), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 08,23), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 08,30), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 09,05), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 09,14), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 09,21), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 09,28), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 10,05), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 10,13), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 10,21), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 10,27), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 11,04), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 11,12), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 11,19), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 11,26), "/Images/1.jpg", "New Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 12,04), "/Images/2.jpg", "First Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 12,12), "/Images/3.jpg", "Full Moon"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 12,18), "/Images/4.jpg", "Last Quarter"));
            MoonPhaseList.Add(new MoonPhase(new DateTime(2019, 12,26), "/Images/1.jpg", "New Moon"));

            SelectedDate = System.DateTime.Today;
            DisplayMoonImageAndDescription();
            ImageFromDateSelected = "/Images/MoonPhases.jpg";
            Description = "Moon Phases";
        }

        private void DisplayMoonImageAndDescription()
        {
            //Check is selected dates is in list
            foreach (MoonPhase m in MoonPhaseList)
            {
                if (m.PhaseStart >= SelectedDate)
                {
                    ImageFromDateSelected = m.ImagePath;
                    Description = m.Description;
                    ScaleFactor = 1;
                    return;
                }

            }

            ImageFromDateSelected = "/Images/MoonPhases.jpg";
            Description = "Moon Phases";
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
