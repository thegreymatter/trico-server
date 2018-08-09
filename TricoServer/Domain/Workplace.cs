using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace TricoServer.Domain
{
    public class Workplace
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public short Rating { get; set; } = 5;
        public string ImageUrl { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public User Host { get; set; }
        public Location Position { get; set; }
        public Schedule Schedule { get; set; } = new Schedule();
        public List<string> Properties { get; set; } = new List<string>();
        public decimal Price { get; set; }
        public long Id { get; set; }
    }

    public class Schedule
    {
        public bool Sunday{ get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
    }

    public class Reservation
    {
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Workplace Workplace { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Location
    {
        public double Lat { get; set; }
        public double Lon { get; set; }

        public Location(double lat, double lon)
        {
            Lat = lat;
            Lon = lon;
        }
    }
}
