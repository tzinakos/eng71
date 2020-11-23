using System;
using System.Linq;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Net.Http;
using RestSharp;

namespace RadioApp
{
    public class Radio
    {

        public static WMPLib.WindowsMediaPlayer radioPlayer = new WMPLib.WindowsMediaPlayer();
        static string chanels = $@"{File.ReadAllText(@"C:\Users\User\github\eng71\OOP\RadioAppStarterCode\RadioApp\JsonFiles\Chanels.json")}";



        //fields
        private static int _channel = 1;
        private static bool _on = false;
        private static List<Chanel> _channelsList = new List<Chanel>();
        private static bool _isPlaying = false;
        private static Chanel _isPlaynigNow;
        private static bool _radioPlayerHasUrl = false;
        private static string _apiResponse;



        // Properties

        public static string ApiResponse
        {
            get { return _apiResponse; }
            set { _apiResponse = value; }
        }
        public int Channel
        {
            get { return _channel; }
            set
            {
                if (_on)
                {
                    if (value > 4 || value <= 0) { }
                    else
                    {
                        _channel = value;
                    }
                }
            }
        }
        public static bool On
        {
            get { return _on; }
            set
            {
                _on = value;

            }
        }

        public static bool RadioPlayerHasUrl
        {
            get { return _radioPlayerHasUrl; }
            set { _radioPlayerHasUrl = value; }
        }

        public static bool IsPlaying
        {
            get { return _isPlaying; }
            set { _isPlaying = value; }
        }
        public static List<Chanel> ChanelList
        {
            get { return _channelsList; }
            set { _channelsList = value; }
        }

        public static Chanel IsPlayingNow
        {
            get { return _isPlaynigNow; }
            set { _isPlaynigNow = value; }
        }

        //Methods.

        //Constructor Methods
        public Radio(int Channel)
        {
            _channel = Channel;


        }
        public Radio()
        {

        }

        //This Method looks in the json file for items, for each item it creates a new chanel class and adds it the the channelList List
        public async System.Threading.Tasks.Task CreateChannelsAsync()
        {
            JObject radioChanels = JObject.Parse(chanels);
            foreach (var item in radioChanels["channel"])
            {
                var name = (string)item["Name"];
                var url = (string)item["Url"];
                var description = (string)item["Description"];
                var country = (string)item["Country"];
                var favorite = (string)item["Favorite"];
                var category = (string)item["Category"];
                ChanelList.Add(new Chanel(name, description, country, category, favorite, url));

            }
            //making Http Request to Get Uk radio Stations in a JSON Format
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://30-000-radio-stations-and-music-charts.p.rapidapi.com/rapidapi?genre=ALL&search_keyword=All&country=Uk"),
                Headers =
                    {
                        { "x-rapidapi-key", "2ce420e0c6msh463f1f0301ffc8cp186020jsn21ac736ef59a" },
                        { "x-rapidapi-host", "30-000-radio-stations-and-music-charts.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                _apiResponse = body;

            }
            JObject radioChanelsFromApi = JObject.Parse(_apiResponse);
            foreach (var item in radioChanelsFromApi["results"])
            {
                var name = (string)item["n"];
                var url = (string)item["u"];
                var description = (string)item["n"];
                var country = (string)item["c"];
                var favorite = "0";
                var category = (string)item["n"];
                ChanelList.Add(new Chanel(name, description, country, category, favorite, url));
                if (ChanelList.Count >= 12)
                {
                    break;
                }

            }
            //making Http Request to Get GR radio Stations in a JSON Format
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://30-000-radio-stations-and-music-charts.p.rapidapi.com/rapidapi?genre=ALL&search_keyword=All&country=Gr"),
                Headers =
                    {
                        { "x-rapidapi-key", "2ce420e0c6msh463f1f0301ffc8cp186020jsn21ac736ef59a" },
                        { "x-rapidapi-host", "30-000-radio-stations-and-music-charts.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                _apiResponse = body;

            }
            radioChanelsFromApi = JObject.Parse(_apiResponse);
            foreach (var item in radioChanelsFromApi["results"])
            {
                var name = (string)item["n"];
                var url = (string)item["u"];
                var description = (string)item["n"];
                var country = (string)item["c"];
                var favorite = "0";
                var category = (string)item["n"];
                ChanelList.Add(new Chanel(name, description, country, category, favorite, url));
               

            }

        }
        //This Method Takes As a Parameter A string Url. It streams from that urll.
        public static string Play(string url)
        {
            if (_on == false)
            {
                return "Radio is off";
            }
            else
            {
                foreach(var item in ChanelList)
                {
                    if (item.Url == url)
                    {
                        _isPlaynigNow = item;

                    }
                }
                radioPlayer.URL = url;
                radioPlayer.settings.volume = 100;
                radioPlayer.controls.play();
                _isPlaying = true;
                
                _radioPlayerHasUrl = true;
                return $"Playing channel {_channel}";

            }
        }
        //This Method Turns Off The Radio
        public static void TurnOff()
        {
            _on = false;
            radioPlayer.controls.stop();
            _isPlaying = false;
        }

        //This Method Turns On The Radio
        public static void TurnOn()
        {
            _on = true;

        }

        //This Method Adjusts the volume of the Radio
        public static void SetPlayerVolume(int volume)
        {
            radioPlayer.settings.volume = volume;
        }

        //This Method Adds / Removes the Chanell To / From the Favorites
        public static void AddToFavorites(string url)
        {
            foreach (var item in ChanelList)
            {
                if (item.Url == url)
                {
                    if (item.Favorite == "0")
                    {
                        item.Favorite = "1";
                    }
                    else item.Favorite = "0";
                }
            }
        }

        public static void PlayNext()
        {
            if (_on)
            {
                if (IsPlaying)
                {
                    for (int i = 0; i < ChanelList.Count; i++)
                    {
                        if (IsPlayingNow.Url == ChanelList[i].Url)
                        {
                            if (i == ChanelList.Count - 1) // if it is the last item in the list, play from the begining
                            {
                                Play(ChanelList[0].Url);
                                break;
                            }
                            else
                            {
                                Play(ChanelList[i + 1].Url);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void PlayPrevious()
        {
            if (_on)
            {
                if (IsPlaying)
                {
                    for (int i = 0; i < ChanelList.Count; i++)
                    {
                        if (IsPlayingNow.Url == ChanelList[i].Url)
                        {
                            if (i == 0)// if it is the first item in the list play the last one
                            {
                                Play(ChanelList[ChanelList.Count-1].Url);
                                break;
                            }
                            else
                            {
                                Play(ChanelList[i - 1].Url);
                                break;
                            }
                        }
                    }
                }
            }


        }
        // implement a class Radio that corresponds to the Class diagram 
        //   and specification in the Radio_Mini_Project document
    }
}