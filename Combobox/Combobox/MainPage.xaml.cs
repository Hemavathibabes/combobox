using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Combobox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page,INotifyPropertyChanged
    {
      
       private List<Gender> gender =new List<Gender>();
        public MainPage()
        {
            this.InitializeComponent();
            gender.Add( new Gender { sitem = "Male" });
           gender.Add(new Gender { sitem = "Female" });
            combo.ItemsSource = gender;
          //  this.DataContext = gender;

        }
      
       
      

        public event PropertyChangedEventHandler PropertyChanged;

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // text = (sender as ComboBox).SelectedItem as string;
            string text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
        
        }
    }
}
