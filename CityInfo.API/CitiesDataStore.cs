﻿using CityInfo.API.Models;
using System.Security.Cryptography.X509Certificates;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; set; } = new CitiesDataStore();
        public CitiesDataStore() 
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park in the central, guess the name of it?"
                },
                new CityDto()
                {
                    Id= 2,
                    Name = "Antwerp",
                    Description = "The one with the catedral that was never really finished."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower."
                }
            };

            
        }
    }
}
