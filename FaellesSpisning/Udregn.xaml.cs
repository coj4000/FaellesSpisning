using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using FaellesSpisning.Boliger;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FaellesSpisning
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Udregn : Page
    {
        public Udregn()
        {
            this.InitializeComponent();
        }


        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void Udregning_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void buttom_Click(object sender, RoutedEventArgs e)
        //{
        //    if (comboBox.SelectedIndex == 0)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 1, BørnU3 = 1, Børn = 0, Unge = 2, Voksne = 2 } + Environment.NewLine;
        //    }
        //    if (comboBox.SelectedIndex == 1)
        //    {
        //        textBlock.Text += new Bolig() {bolignr = 2, BørnU3 = 0, Børn = 3, Unge = 0, Voksne = 2} + Environment.NewLine;
        //    }
        //    if (comboBox.SelectedIndex == 2)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 3, BørnU3 = 0, Børn = 1, Unge = 1, Voksne = 3 } + Environment.NewLine;
        //    }
        //    if (comboBox.SelectedIndex == 3)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 4, BørnU3 = 1, Børn = 0, Unge = 2, Voksne = 2 } + Environment.NewLine;
        //    }
        //    if (comboBox.SelectedIndex == 4)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 5, BørnU3 = 0, Børn = 1, Unge = 1, Voksne = 2 } + Environment.NewLine;
        //    }
        //    if (comboBox.SelectedIndex == 5)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 6, BørnU3 = 0, Børn = 2, Unge = 0, Voksne = 1 } + Environment.NewLine;
        //    }
        //    if (comboBox.SelectedIndex == 6)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 7, BørnU3 = 3, Børn = 1, Unge = 0, Voksne = 3 } + Environment.NewLine;
        //    }
        //    if (comboBox.SelectedIndex == 7)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 8, BørnU3 = 2, Børn = 1, Unge = 1, Voksne = 2 } + Environment.NewLine;
        //    }
        //    if (comboBox.SelectedIndex == 8)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 9, BørnU3 = 0, Børn = 3, Unge = 1, Voksne = 1 } + Environment.NewLine;

        //    }
        //    if (comboBox.SelectedIndex == 9)
        //    {
        //        textBlock.Text += new Bolig() { bolignr = 10, BørnU3 = 0, Børn = 0, Unge = 3, Voksne = 2 } + Environment.NewLine;
        //    }
        //}

        //private void clearButton_Click(object sender, RoutedEventArgs e)
        //{
        //    textBlock.Text = "";
        //}
    }
}
