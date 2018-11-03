using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models
{
    public static class AppSettings
    {   //bot configuration
        public static string Url { get; set; } = "https://URL:443/{0}";                  //остаточне посилання на опублікований бот

        public static string Name { get; set; } = "VolunteerX";

        public static string Key { get; set; } = "728827023:AAGBPqiLZJcpU7XD0iyA-uGYnXoFjgplUiw";
    }
}
