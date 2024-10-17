using StandardApplication.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandardApplication.BAL
{
    public class CityProvider
    {
        public List<City> cities;
        public CityProvider() {
            cities = new List<City>()
            {
                new City() {CityId=1,Name="Ahmedabad"},
                new City() {CityId=2,Name="Rajkot"},
                new City() {CityId=3,Name="Nadiad"},
                new City() {CityId=4,Name="Junagadh"},
                new City() {CityId=5,Name="Baroda"},
            };
        }
    }
}