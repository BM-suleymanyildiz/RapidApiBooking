﻿namespace RapidApiBooking.Models
{
    public class SearchHotelViewModel
    {
        public string City { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int AdultCount { get; set; }
        public int RoomCount { get; set; }
    }
}
