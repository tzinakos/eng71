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
            Radio radio = new Radio();
            radio.CreateChannelsAsync();
            
            RefreshChanelsToUI();
            TurnOnOffUI();


        }
  
        public void RefreshChanelsToUI()
        {
            
            int gbChannelsCount = GbRadio.Items.Count;
            int grChannelsCount = GrRadio.Items.Count;
            int FavoritesListCount = FavoritesList.Items.Count;
            for (int i = 1; i < gbChannelsCount; i++)
            {
                GbRadio.Items.RemoveAt(1);                 
            }
            for (int i = 1; i < grChannelsCount; i++)
            {
                GrRadio.Items.RemoveAt(1);
            }
            for (int i = 1; i < FavoritesListCount; i++)
            {
                FavoritesList.Items.RemoveAt(1);
            }

            foreach (var item in Radio.ChanelList)
            {
                if (item.Country == "GB"|| item.Country=="UK")
                {
                    Style style = this.FindResource("ListBoxItemStyle1") as Style;
                    GbRadio.ItemContainerStyle = style;
                    GbRadio.Items.Add(item.Name);          
                 
                }
                else if (item.Country == "Gr" || item.Country == "GR")
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
                   
                    FavoritesList.ItemContainerStyle = style;
                }
            }

        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Radio.SetPlayerVolume((int)VolumeSlider.Value);
        }


        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (Radio.On)
            {
                if (Radio.IsPlaying)
                {

                    Radio.radioPlayer.controls.pause();
                    Radio.IsPlaying = false;
                    PlayButton.Background = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri("C:\\Users\\User\\github\\eng71\\OOP\\RadioAppStarterCode\\RadioAppWPF\\Play.png"))

                    };
                    Image1.IsEnabled = false;
                    Image2.IsEnabled = false;

                }
                else
                {
                    if (Radio.RadioPlayerHasUrl == true)
                    {
                        Radio.radioPlayer.controls.play();
                        Radio.IsPlaying = true;
                        PlayButton.Background = new ImageBrush
                        {
                            ImageSource = new BitmapImage(new Uri("C:\\Users\\User\\github\\eng71\\OOP\\RadioAppStarterCode\\RadioAppWPF\\Pause.png")),

                        };
                        Image1.IsEnabled = true;
                        Image2.IsEnabled = true;
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void DoubleCklick(object sender, RoutedEventArgs e)
        {
            if (Radio.On)
            {
                var chanel = (sender as ListBox).SelectedItem.ToString(); ;

                string selectedChanel = "";
                string selectedFav = "";

                foreach (var item in Radio.ChanelList)
                {
                    if (item.Name == chanel)
                    {
                        selectedChanel = item.Url;
                        selectedFav = item.Favorite;
                        ApplicationName.Text = $"{item.Country} Radio Station";
                        NowPlaying.Text = $"Now Playing: {item.Name}";
                        Description.Text = item.Description;
                        
                    }

                }
                Radio.Play(selectedChanel);
                Image1.IsEnabled = true;
                Image2.IsEnabled = true;

                if (selectedFav == "1")
                {
                    FavButton.Background = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri("C:\\Users\\User\\github\\eng71\\OOP\\RadioAppStarterCode\\RadioAppWPF\\Fav.png"))
                    };
                }else
                {
                    FavButton.Background = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri("C:\\Users\\User\\github\\eng71\\OOP\\RadioAppStarterCode\\RadioAppWPF\\UFav.png"))
                    };
                }
                PlayButton.Background = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri("C:\\Users\\User\\github\\eng71\\OOP\\RadioAppStarterCode\\RadioAppWPF\\Pause.png")),

                };

            }
            else return;

        }

        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            if (Radio.On)
            {
                Radio.TurnOff();
                PlayButton.Background = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri("C:\\Users\\User\\github\\eng71\\OOP\\RadioAppStarterCode\\RadioAppWPF\\Play.png"))

                };
                TurnOnOffUI();


            }
            else Radio.TurnOn();
            TurnOnOffUI();
        }

        private void TurnOnOffUI()
        {
            if(Radio.On)
            {
                PlayButton.Opacity = 1;
               
                NextButton.Opacity = 1;
                PreviusButton.Opacity = 1;
                FavButton.Opacity = 1;
                ApplicationName.Text = "Listen To Your Favorite Radio Station.";
                Description.Text = "";
                NowPlaying.Text = "Select A Radio Chanel.";
            }
            else
            {
                PlayButton.Opacity = .5;
                NextButton.Opacity = .5;
                PreviusButton.Opacity =.5;
                FavButton.Opacity = .5;
                ApplicationName.Text = "Listen To Your Favorite Radio Station.";
                Description.Text = "";
                NowPlaying.Text = "Turn On The Radio And Enjoy";
                Image1.IsEnabled = false;
                Image2.IsEnabled = false;
               
            }   
        }

        private void FavButton_Click(object sender, RoutedEventArgs e)
        {   
            Radio.AddToFavorites(Radio.IsPlayingNow.Url);

            if (Radio.IsPlayingNow.Favorite == "0")
            {
                FavButton.Background = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri("C:\\Users\\User\\github\\eng71\\OOP\\RadioAppStarterCode\\RadioAppWPF\\UFav.png"))
                };
            }
            else
            {
                FavButton.Background = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri("C:\\Users\\User\\github\\eng71\\OOP\\RadioAppStarterCode\\RadioAppWPF\\Fav.png"))
                };
            }
            RefreshChanelsToUI();
        }

        private void HumButon_Click(object sender, RoutedEventArgs e)
        {
            GrRadio.IsEnabled = !GrRadio.IsEnabled;
            GbRadio.IsEnabled = !GbRadio.IsEnabled;
            FavoritesList.IsEnabled = !FavoritesList.IsEnabled;
            RefreshChanelsToUI();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (Radio.IsPlaying)
            {
                Radio.PlayNext();

                ApplicationName.Text = $"{Radio.IsPlayingNow.Country} Radio Station";
                NowPlaying.Text = $"Now Playing: {Radio.IsPlayingNow.Name}";
                Description.Text = Radio.IsPlayingNow.Description;
            }
        }

        private void PreviusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Radio.IsPlaying)
            {
                Radio.PlayPrevious();
                ApplicationName.Text = $"{Radio.IsPlayingNow.Country} Radio Station";
                NowPlaying.Text = $"Now Playing: {Radio.IsPlayingNow.Name}";
                Description.Text = Radio.IsPlayingNow.Description;
            }
        }
    }

}
