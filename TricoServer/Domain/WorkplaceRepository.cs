using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TricoServer.Domain
{
    public class DataRepository
    {

        public static DataRepository Instance = new DataRepository();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        List<Workplace> Workplaces = new List<Workplace>()
        {
            new Workplace
            {
                Id =1,
                Address = "Hertzel 124, Tel Aviv",
                Position = new Location(32.4,23.2),
                Host = new User(){Name = "Smithy Smith"},
                ImageUrl = "http://www.google.com",
                Schedule = new Schedule(){Monday = true},
                Properties = new List<string>(){"Wifi","Hot-Tub"},
                Price = 32.0M


            },
            new Workplace
            {
                Id =2,
                Address = "Hertzel 100, Tel Aviv",
                Position = new Location(32.4,23.2),
                Host = new User(){Name = "JessicaRabbit"},
                ImageUrl = "http://www.google.com",
                Schedule = new Schedule(){Sunday = true},
                Properties = new List<string>(){"Wifi"},
                Price = 32.0M


            }
        };

        public List<Workplace> GetWorplaces()
        {
            return Workplaces;
        }

        public void AddWorkplace(Workplace workplace)
        {
             Workplaces.Add(workplace);
        }


        public List<Reservation> GetReservations(string userMail)
        {
           return Reservations.Where(x => x.User.Mail==userMail).ToList();
        }

        public Reservation Reserve(User user, Workplace workplace,DateTime date)
        {
            var reservation = new Reservation()
            {
                Workplace = workplace,
                Date = date,
                User = user
            };


            Reservations.Add(reservation);
            return reservation;
        }


    }
}
