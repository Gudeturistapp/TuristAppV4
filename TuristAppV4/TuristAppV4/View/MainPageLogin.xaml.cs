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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using TuristAppV4.Model;

namespace TuristAppV4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    ///

    public sealed partial class MainPage : Page
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>(); 

        public MainPage()
        {

            this.InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NameBox.Text != "" && PassBox.Password != "")
            {
               
                dictionary.Add(PassBox.Password, NameBox.Text);

                Frame.Navigate(typeof(View.MainPage));



            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           

            if (dictionary.ContainsKey(PassBox.Password) &&
                dictionary.ContainsValue(NameBox.Text))
            {
                Frame.Navigate(typeof (View.MainPage));
            }
            else
            {
                ErrorBox.Text = "Error! User not found";
            }
        }
    }
}
