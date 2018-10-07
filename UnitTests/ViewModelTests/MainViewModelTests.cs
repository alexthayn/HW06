using HW06_AThayn.Model;
using HW06_AThayn.ViewModel;
using NUnit.Framework;
using System;
using System.Collections.ObjectModel;

namespace UnitTests
{
    [TestFixture]
    public class MainViewModelTests
    {
        MainViewModel vm;

        [SetUp]
        public void Setup()
        {
            var list = new ObservableCollection<MoonPhase>
            {
                new MoonPhase(new DateTime(2001, 01, 01), "Hello.jpg", "Hello"),
                new MoonPhase(new DateTime(2001, 01, 08), "Superman.jpg", "Superman picture"),
                new MoonPhase(new DateTime(2001, 01, 16), "Spiderman.jpg", "Spiderman picture"),
                new MoonPhase(new DateTime(2001, 01, 24), "Batman.jpg", "Batman picture"),
                new MoonPhase(new DateTime(2001, 01, 31), "Flash.jpg", "Flash picture"),
                new MoonPhase(new DateTime(2001, 02, 07), "IronMan.jpg", "IronMan picture")
            };

            vm = new MainViewModel
            {
                MoonPhaseList = list
            };
        }

        [Test]
        public void TestCorrectImageIsReturnedWhenSelectedDateChanges()
        {
            vm.SelectedDate = new DateTime(2001, 1, 22);
            string img = vm.ImageFromDateSelected;

            Assert.AreEqual("Batman.jpg", img);

            vm.SelectedDate = new DateTime(2001, 1, 29);
            string newImg = vm.ImageFromDateSelected;

            Assert.AreEqual("Flash.jpg", newImg);
        }

        [Test]
        public void TestThatGivenADateWeReturnCorrectDescription()
        {
            vm.SelectedDate = new DateTime(2001, 1, 7);
            string d = vm.Description;

            Assert.AreEqual("Superman picture", d);
        }

        [Test]
        public void TestThatGivenANewDateScaleFactorIsResetToOne()
        {
            vm.SelectedDate = new DateTime(2001, 1, 7);
            double s = vm.ScaleFactor;

            Assert.AreEqual(1, s);
        }

        [Test]
        public void TestThatImageReturnedIsFromDateBeforeOrOnGivenDate()
        {
            vm.SelectedDate = new DateTime(2000, 12, 31);
            string img = vm.ImageFromDateSelected;

            Assert.AreEqual("Hello.jpg", img);
        }

        [Test]
        public void TestThatImageReturnedIsDefaultIfDateIsAfterLastGivenDate()
        {
            vm.SelectedDate = new DateTime(2002, 1, 1);
            string img = vm.ImageFromDateSelected;

            Assert.AreEqual("/Images/MoonPhases.jpg", img);
        }
    }
}
