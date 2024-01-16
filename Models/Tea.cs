using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodTeas.Models
{
    internal class Tea
    {
        public string Name;
        public string Type;
        public string CaffeineContent;
        public string SteepTime;
        public string WaterTemperature;
        public string Notes;
        public string Rating;

        /// <summary>
        /// Initialize the Tea instance
        /// </summary>
        /// <param name="name">Name of the tea</param>
        /// <param name="type">Type of tea</param>
        /// <param name="caffeineContent">Amount of Caffeine in mg</param>
        /// <param name="steepTime">Steep time in minutes</param>
        /// <param name="waterTemperature">Temeprature of the water in °F</param>
        /// <param name="notes">Notes on the tea</param>
        /// <param name="rating">User specified rating</param>
        public Tea(string name, string type, 
            string caffeineContent, string steepTime, 
            string waterTemperature, string notes, string rating)
        {
            Name = name;
            Type = type;
            CaffeineContent = caffeineContent;
            SteepTime = steepTime;
            WaterTemperature = waterTemperature;
            Notes = notes;
            Rating = rating;
            Notes = notes;
            Rating = rating;
        }
    }
}
