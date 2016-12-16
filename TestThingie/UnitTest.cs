using System;
using Windows.Devices.Bluetooth.Advertisement;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using FaellesSpisning.Boliger;

namespace TestThingie
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void husStandMedDeltagere()
        {

            //setup
            Bolig testBolig = new Bolig() {bolignr = 12, Børn = 1, BørnU3 = 0, Unge = 1, Voksne = 2};
            
            double expected = 2.75;

            //Læg sammen
            //testBolig.AntalKuverter();

            //test stuff
            double actual = testBolig.SumAfDeltagere();
            Assert.AreEqual(expected, actual, 0.001, "i har ikke beregnet ordenligt!");
            Assert.AreEqual(4, testBolig.AntalKuverter());
        }
    }
}
