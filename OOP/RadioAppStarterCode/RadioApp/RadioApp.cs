using System;
using System.Linq;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace RadioApp
{
    public  class Radio
    {

        
        static string json = @"{
  'channel': [
              {
            'Name': 'Rock Fm 96.9',
            'Description': '96.9 ROCK FM is one of the most historic stations in Athens since it has been broadcasting since 1989! On Rock FM you listen to your favorite rock and not only songs from all eras. From the beginning it continues steadily with the same name, which makes it one of the most historic stations in the city. The name of the station also defines its musical identity, but this does not create strict limits, hosting all the musical colors of this and every era.',
            'Country': 'Gr',
            'Category': 'Rock',
            'Favorite':'0',
            'Url': 'http://rockfmlive.mdc.akamaized.net/strmRCFm/userRCFm/playlist.m3u8'
            },
               {
            'Name': 'Rock Fm 96.9',
            'Description': '96.9 ROCK FM is one of the most historic stations in Athens since it has been broadcasting since 1989! On Rock FM you listen to your favorite rock and not only songs from all eras. From the beginning it continues steadily with the same name, which makes it one of the most historic stations in the city. The name of the station also defines its musical identity, but this does not create strict limits, hosting all the musical colors of this and every era.',
            'Country': 'Gr',
            'Category': 'Rock',
            'Favorite':'0',
            'Url': 'http://rockfmlive.mdc.akamaized.net/strmRCFm/userRCFm/playlist.m3u8'
            },
          {
            'Name': 'Mad Radio 106.2',
            'Description': 'How beautiful to have all the great foreign hits in one station! MAD radio broadcast on 106.2 MHz on June 6, 1996 in the summer of 2006 with Andreas M. Kouris at the helm. Well-known producers have switched to MAD radio and today excel at other frequencies. MAD radio is in its 11th year this year and continues its course with the same passion. It was the (former Ecstasy 106.2, South FM 106.1, Diva FM 106.1)! The station is owned by MAD TV Societe Anonyme, which was founded on January 9, 1995, and Solar Broadcasting and Entertainment Services Societe Anonyme. Their shareholder is PandaLaw Management Limited (100%) in which MAD Television Licensing Limited (90%) and Maria Kontomina (10%) participate. MAD radio could not be absent from the family of Live24.gr!',
            'Country': 'Gr',
            'Category': 'Pop',
            'Favorite': '0',
            'Url': 'http://mediaserver.mad.tv:80/stream'
          },
          {
            'Name': 'Athens Dj 95.2',
            'Description': '95.2 Athens DeeJay is a youth radio station founded in 2000! Every morning 7-10 starts dynamically with Michalis Tsousopoulos and Breakfast on FM! Athens DeeJay is very high in the preferences of pupils and students and plays mainly foreign mainstream! 95.2 Athens DeeJay enables its listeners to win unique gifts such as monthly rent, cash and invitations to go out. Athens DeeJay only plays Successes on Live24.gr',
            'Country': 'Gr',
            'Category': 'pop',
            'Favorite': '0',
            'Url': 'http://netradio.live24.gr:80/athensdeejay'
          },
          {
            'Name': 'BBC Radio 1',
            'Description': '',
            'Country': 'GB',
            'Category': 'BBC',
            'Favorite': '0',
            'Url': 'http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p'
          },
          {
            'Name': 'BBC Radio 2',
            'Description': '',
            'Country': 'GB',
            'Category': 'BBC',
            'Favorite': '0',
            'Url': 'http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio2_mf_p'
          },
          {
            'Name': 'BBC Radio 3',
            'Description': '',
            'Country': 'GB',
            'Category': 'BBC',
            'Favorite': '0',
            'Url': 'http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio3_mf_p'
          },
          {
            'Name': 'BBC Radio 4',
            'Description': '',
            'Country': 'GB',
            'Category': 'BBC',
            'Favorite': '0',
            'Url': 'http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio4fm_mf_p'
          }
            ]
          
}";

      



        //fields
        private int _channel =1 ;
        private bool _on = false;
        private static List<Chanel> _channelsList = new List<Chanel>();

        // Properties

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
        public static List<Chanel> ChanelList
        {
            get { return _channelsList; }
            set { _channelsList = value; }
        }


        //Methods.
        public Radio(int Channel)
        {
            _channel = Channel;


        }
        public Radio()
        {

        }
        
      
        
        
        
       
        
        public void CreateChannels()
        {
            JObject rss = JObject.Parse(json);
            foreach( var item in rss["channel"])
            {
                var name = (string)item["Name"];
                var url = (string)item["Url"];
                var description = (string)item["Description"];
                var country = (string)item["Country"];
                var favorite = (string)item["Favorite"];
                var category = (string)item["Category"];
                ChanelList.Add(new Chanel(name, description, country, category, favorite, url));            
            }
           
          
        }

        public string Play()
        {
            if (_on == false)
            {
                return "Radio is off";
            }
            else
                return $"Playing channel {_channel}";
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }


    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}