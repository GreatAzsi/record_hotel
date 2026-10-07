using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace record_hotel
{
    internal record Hotel(string Name, string City, string Category, string Owner, int TotalRooms)

    {
        private string _owner { get; init; } = Owner;
        public int PricePerNight { get; set; }
        public double Rating { get; set; }
        private int AvailableRooms { get; set; }
        private int _totalRooms { get; init; } = TotalRooms;
        public void SetAvailableRooms(int Rooms)
        {
            AvailableRooms = Rooms;
        }

        public int GetPricePerNight()
        {
            return PricePerNight;
        }
        public double GetRating()
        {
            return Rating;
        }
        public int GetAvailableRooms() 
        {
            return AvailableRooms;
        }
        public string GetOwner()
        {
            return _owner;
        }
        public void SetDiscount(int Precentage)
        {
            PricePerNight *= (100 - Precentage)/100;
        }
        public void SetUpcharge(int Upcharge)
        {
            PricePerNight *= (100 + Upcharge) / 100;
        }
        public void ChangeRating(double newRating)
        {
            Rating = newRating;
        }
        public bool IsUpstanding()
        {
            return Rating >= 9.0;
        }
        public bool Is10Available()
        {
            return AvailableRooms >= 10;
        }
        public int GetUnavailableRooms()
        {
            return TotalRooms - AvailableRooms;
        }
        public double PrecentageOfHotel()
        {
            return Math.Round((double)GetUnavailableRooms()/Convert.ToDouble(TotalRooms)*100,2);
        }
        public void ReserverRooms(int Rooms)
        {
            AvailableRooms = AvailableRooms >= Rooms ? AvailableRooms -= Rooms : AvailableRooms = AvailableRooms;
        }
        public void ClearRooms(int Rooms)
        {
            AvailableRooms = TotalRooms <= AvailableRooms + Rooms ? AvailableRooms += Rooms : AvailableRooms = AvailableRooms;
        }
        public int NightsPrice(int Nights)
        {
            return (PricePerNight * Nights);
        }
        public int SummaPrice(int Nights, int Rooms)
        {
            return (NightsPrice(Nights) * Rooms);
        }
        public bool IsCheaperThan(int Price)
        {
            return PricePerNight < Price;
        }
        public bool IsBetterRatedThan(double CompareRating)
        {
            return Rating>= CompareRating;
        }
        public string Describe()
        {
            return $"{Name}, {City}, {Category}, {Owner} {TotalRooms}, {AvailableRooms}";
        }

    }
}
