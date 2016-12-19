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
using FaellesSpisning.Planlægning;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FaellesSpisning
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            comboBox1.Items.Add("bolignr = 1, BørnU3 = 1, Børn = 0, Unge = 2, Voksne = 2");
            comboBox1.Items.Add("bolignr = 2, BørnU3 = 0, Børn = 3, Unge = 0, Voksne = 2");
            comboBox1.Items.Add("bolignr = 3, BørnU3 = 0, Børn = 1, Unge = 1, Voksne = 3");
            comboBox1.Items.Add("bolignr = 4, BørnU3 = 1, Børn = 0, Unge = 2, Voksne = 2");
            comboBox1.Items.Add("bolignr = 5, BørnU3 = 0, Børn = 1, Unge = 1, Voksne = 2");
            comboBox1.Items.Add("bolignr = 6, BørnU3 = 0, Børn = 2, Unge = 0, Voksne = 1");
            comboBox1.Items.Add("bolignr = 7, BørnU3 = 3, Børn = 1, Unge = 0, Voksne = 3");
            comboBox1.Items.Add("bolignr = 8, BørnU3 = 2, Børn = 1, Unge = 1, Voksne = 2");
            comboBox1.Items.Add("bolignr = 9, BørnU3 = 0, Børn = 3, Unge = 1, Voksne = 1");
            comboBox1.Items.Add("bolignr = 10, BørnU3 = 0, Børn = 0, Unge = 3, Voksne = 2");


        }

        private void Tilføj_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox.Text += "bolignr = 1, BørnU3 = 1, Børn = 0, Unge = 2, Voksne = 2" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox.Text += "bolignr = 2, BørnU3 = 0, Børn = 3, Unge = 0, Voksne = 2" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox.Text += "bolignr = 3, BørnU3 = 0, Børn = 1, Unge = 1, Voksne = 3" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox.Text += "bolignr = 4, BørnU3 = 1, Børn = 0, Unge = 2, Voksne = 2" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBox.Text += "bolignr = 5, BørnU3 = 0, Børn = 1, Unge = 1, Voksne = 2" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                textBox.Text += "bolignr = 6, BørnU3 = 0, Børn = 2, Unge = 0, Voksne = 1" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                textBox.Text += "bolignr = 7, BørnU3 = 3, Børn = 1, Unge = 0, Voksne = 3" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                textBox.Text += "bolignr = 8, BørnU3 = 2, Børn = 1, Unge = 1, Voksne = 2" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                textBox.Text += "bolignr = 9, BørnU3 = 0, Børn = 3, Unge = 1, Voksne = 1" + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 9)
            {
                textBox.Text += "bolignr = 10, BørnU3 = 0, Børn = 0, Unge = 3, Voksne = 2" + Environment.NewLine;
            }
        }


        private void Buttonredirect_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Udregn), null);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tilføj_Copy1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }
    }
}
