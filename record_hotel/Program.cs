using System;
using System.Threading.Channels;

namespace record_hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hotel> hotels = new List<Hotel>()
{
    new Hotel("Danube Palace", "Budapest", "Luxury", "Danube Group", 52000, 9.3, 12, 80) { PricePerNight = 52000, Rating = 8.6 },
    new Hotel("Central Garden", "Budapest", "Standard", "City Hotels", 28000, 8.4, 25, 70){PricePerNight = 28000, Rating = 8.6},
    new Hotel("Royal Budapest", "Budapest", "Luxury", "Royal Hotels", 61000, 9.5, 8, 90){PricePerNight = 61000, Rating = 8.6},
    new Hotel("Balaton Resort", "Siofok", "Resort", "Lake Group", 44000, 8.8, 30, 120){PricePerNight = 44000, Rating = 8.6},
    new Hotel("Sunset Hotel", "Siofok", "Standard", "Lake Group", 31000, 8.2, 18, 65){PricePerNight = 31000, Rating = 8.6},
    new Hotel("Golden Beach", "Siofok", "Luxury", "Royal Hotels", 57000, 9.1, 15, 85){PricePerNight = 57000, Rating = 9.1},
    new Hotel("Forest Lodge", "Eger", "Standard", "Nature Hotels", 55){PricePerNight = 26000, Rating = 8.6},
    new Hotel("Castle View", "Eger", "Luxury", "Royal Hotels", 6){ PricePerNight = 49000, Rating =  9.2 },
    
            };
            hotels[0].SetAvailableRooms(12);
            hotels[1].SetAvailableRooms(25);
            hotels[2].SetAvailableRooms(8);
            hotels[3].SetAvailableRooms(30);
            hotels[4].SetAvailableRooms(18);
            hotels[5].SetAvailableRooms(15);
            hotels[6].SetAvailableRooms(20);
            hotels[7].SetAvailableRooms(60);
            Console.WriteLine(hotels.Sum(x=>x.GetAvailableRooms()));
            Console.WriteLine(hotels.Where(x=>x.City== "Budapest").Average(x=>x.PricePerNight));
            Console.WriteLine(hotels.OrderBy(x=>x.PricePerNight).Select(x=>x.Name).First());
            hotels.Select(x=>x.Category).Distinct().ToList().ForEach(x=> Console.WriteLine(x));
            foreach(KeyValuePair<string,int> item in hotels.GroupBy(x=>x.City).ToDictionary(x=>x.Key, x => x.Count())) { Console.WriteLine($"{item.Key}: {item.Value}"); }
            foreach(KeyValuePair<string,double> item in hotels.GroupBy(x => x.Category).ToDictionary(x => x.Key, x=>x.Average(y => y.PricePerNight){ Console.WriteLine($"{item.Key}: {item.Value}"); }
        }
        
    }
}
