using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Address
    {
        public string name;
        public int houseNum;
        public string lineOne;
        public string town;
        public string county;
        public string country;


        public Address()
        {
            name = "";
            houseNum = 0;
            lineOne = "";
            town = "";
            county = "";
            country = "";
        }

        public Address(string n, int hn, string l1, string t, string cnty, string cntry)
        {
            name = n;
            houseNum = hn;
            lineOne = l1;
            town = t;
            county = cnty;
            country = cntry;
        }

        public Address(string n, string l1, string t, string cnty, string cntry)
        {
            name = n;
            lineOne = l1;
            town = t;
            county = cnty;
            country = cntry;
        }
    }
}
