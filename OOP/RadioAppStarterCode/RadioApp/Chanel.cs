using System;
using System.Collections.Generic;
using System.Text;

namespace RadioApp
{
    public class Chanel
    {
        //fields
        private string _name, _country, _category, _description, _favorite, _url;

        //properties
        public string Name
        {
            get{ return _name; }
            set { _name = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Favorite
        {
            get { return _favorite; }
            set { _favorite = value; }
        }
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public Chanel(string name, string description, string country, string category, string favorite, string url)
        {
            _name = name;
            _description = description;
            _country = country;
            _category = category;
            _favorite = favorite;
            _url = url;
        }

    }
}
