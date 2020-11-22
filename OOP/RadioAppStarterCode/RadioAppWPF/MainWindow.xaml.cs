using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using RadioApp;

namespace RadioAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            PlayMusicFromURL("https://internetradiouk.com/#kiss-london");
            somethinsg();


            
           
        }
  
        public bool isOn = true;
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        
        public static void PlayMusicFromURL(string url)
        {
            player.URL = url;

            player.settings.volume = 100;

            player.controls.play();
        }
        public void somethinsg()
        {
            
            Radio radio = new Radio();
            radio.CreateChannels();
            foreach (var item in Radio.ChanelList)
            {
                if (item.Country == "GB")
                {
                    Style style = this.FindResource("ListBoxItemStyle1") as Style;
                    GbRadio.ItemContainerStyle = style;
                    GbRadio.Items.Add(item.Name);
                   
                 
                }
                else if (item.Country == "Gr")
                {
                    Style style = this.FindResource("ListBoxItemStyle1") as Style;
                    FavoritesList.ItemContainerStyle = style;
                    GrRadio.ItemContainerStyle = style;
                    GrRadio.Items.Add(item.Name);
                    
                }
                if(item.Favorite == "1")
                {
                    Style style = this.FindResource("ListBoxItemStyle1") as Style;
                    FavoritesList.Items.Add(item.Name);
                    FavoritesList.ItemContainerStyle = Style;
                }
            }

        }
        public static void PlayerStop(string url)
        {
            player.controls.stop();
        }

        public static void SetPlayerVolume(int volume)
        {
            player.settings.volume = volume;
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SetPlayerVolume((int)VolumeSlider.Value);
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                player.controls.pause();
                isOn = false;
            }
            else
            {
                player.controls.play();
                isOn = true;
            }
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }
        private void DoubleCklick(object sender, RoutedEventArgs e)
        {
            var chanel = (sender as ListBox).SelectedItem.ToString(); ;

            string next = "";
            
            foreach (var item in Radio.ChanelList)
            {
                if (item.Name == chanel) 
                {
                    next = item.Url;
                    ApplicationName.Text = $"{item.Country} Radio Station";
                    NowPlaying.Text = $"Now Playing: {item.Name}";
                    Description.Text = item.Description;
                }
                
            }
            PlayMusicFromURL(next);



        }
    }
}
