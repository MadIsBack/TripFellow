
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelPlaner.Business.Data;
using TravelPlaner.Business.Interfaces;
using TravelPlaner.Business.Events;

namespace TravelPlaner.Business.Data
{
    public class Travel
    {
        public TravelItemList Items { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private Travel GetMyIreland()
        {
            var airportBer = new Airport
            {
                City = "Berlin",
                Code = "BER",
                TypeOfTarget = "Airport",
                Country = "DE",
                Name = "Flughafen Willy Brandt Berlin Brandenburg",
                Longitude = 13.508999,
                Latitude = 52.364044,
                TimeZone = TimeZoneInfo.FindSystemTimeZoneById("CET")
            };
            var airportDbl = new Airport
            {
                City = "Dublin",
                Code = "DBL",
                TypeOfTarget = "Airport",
                Country = "IR",
                Name = "Flughafen Dublin",
                Longitude = -6.249910,
                Latitude = 53.426448                ,
                TimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT")
            };

            var travel = new Travel { Name = "Irland'23", Description = "Rundreise durch Irland" };
            travel.Items.Add(new FlightEvent
            {
                Name ="Hinflug",
                Description = "Hinflug",
                DepartureAirport = airportBer,
                DepartureTime = new DateTime(2023, 6, 10, 10, 40, 00, DateTimeKind.Local),
                ArrivalAirport = airportDbl,
                ArrivalTime = new DateTime(2023, 6, 10, 12, 10, 00, DateTimeKind.Local),
                PriceForPersons = 0,
                Price = 605
            });

            travel.Items.Add(new FlightEvent
            {
                Name="Rückflug",
                Description = "Rückflug",
                DepartureAirport = airportDbl,
                DepartureTime = new DateTime(2023, 6, 23, 17, 45, 00, DateTimeKind.Local),
                ArrivalAirport = airportBer,
                ArrivalTime = new DateTime(2023, 6, 23, 21, 05, 00, DateTimeKind.Local),
                PriceForPersons = 0,
                Price = 605
            });
            travel.Items.Add(new RentalCarEvent
            {
                Name="Mietwagen",
                Company = "Avis",
                Start = new DateTime(2023, 6, 10, 12, 30, 00, DateTimeKind.Local),
                End = new DateTime(2023, 6, 20, 16, 00, 00, DateTimeKind.Local),
                Price = 545.39,
                PriceForPersons = 0,
                Currency = "EUR"
            });
            travel.Items.Add(new PoiEvent
            {
                Name = "Newgrange",
                TypeOfPoi = "Sehenswürdigkeit",
                Longitude = -6.475582,
                Latitude = 53.694737
            });
            travel.Items.Add(new LodgingEvent
            {
                Name="Übernachtung Belfast",
                Lodging= new Lodging
                {
                    City = "Belfast",
                    Name = "Lwr Ormeau Guest House",
                    Country = "Nordirland",
                    Street = "144 Ormeau Road",
                    StreetNumber = "144",
                    ZipCode = "BT7 1LU",
                    TypeOfTarget = "Hotel"
                },
                Currency="UK Pound",
                Price = 295,
                PriceForPersons=0,
                Start = new DateTime(2023, 6, 10, 18, 00, 00, DateTimeKind.Local),
                End = new DateTime(2023, 6, 13, 10, 00, 00, DateTimeKind.Local),
            });

            travel.Items.Add(new PoiEvent
            {
                Name = "Giants Causeway",
                TypeOfPoi = "Sehenswürdigkeit",
                EventDateTime = new DateTime(2023, 6, 11, 10, 0, 0, DateTimeKind.Local),
                Longitude = -6.511555,
                Latitude = 55.240807
            });
            travel.Items.Add(new PoiEvent
            {
                Name = "Bushmills Distillery",
                TypeOfPoi = "Sehenswürdigkeit",
                EventDateTime = new DateTime(2023, 6, 11, 12, 0, 0, DateTimeKind.Local),
                Longitude = -6.518712,
                Latitude = 55.198124
            });
            travel.Items.Add(new PoiEvent
            {
                Name = "Carrick-a-Rede Brücke",
                TypeOfPoi = "Sehenswürdigkeit",
                EventDateTime = new DateTime(2023, 6, 11, 15, 0, 0, DateTimeKind.Local),
                Longitude = -6.332620,
                Latitude = 55.239540,

            });
            travel.Items.Add(new PoiEvent
            {
                Name = "The Dark Hedges",
                TypeOfPoi = "Sehenswürdigkeit",
                EventDateTime = new DateTime(2023, 6, 11, 13, 0, 0, DateTimeKind.Local),
                Latitude = 55.13497503686638,
                Longitude = -6.382066549878735,
                Priority = 3
            });
            travel.Items.Add(new PoiEvent
            {
                Name = "Titanic Museum",
                TypeOfPoi = "Museum",
                EventDateTime = new DateTime(2023, 6, 12, 10, 0, 0, DateTimeKind.Local),
                Longitude = -5.910092,
                Latitude = 54.608099,
            });
            travel.Items.Add(new PoiEvent
            {
                Name = "Cong Abbey",
                TypeOfPoi = "Sehenswürdigkeit",
                EventDateTime = new DateTime(2023, 6, 13, 11, 0, 0, DateTimeKind.Local),
                Latitude =53.5459228734875,
                Longitude =-9.288206291975262,
                Priority = 5
            });
            travel.Items.Add(new LodgingEvent
            {
                Name = "Übernachtung Galway",
                Lodging = new Lodging
                {
                    City = "Belfast",
                    Name = "The Lane - Boutiques Residence",
                    Country = "Irland",
                    Street = "",
                    StreetNumber = "",
                    ZipCode = "",
                    TypeOfTarget = "Hotel"
                },
                Currency = "Euro",
                Price = 268.20,
                PriceForPersons = 0,
                Start = new DateTime(2023, 6, 13, 18, 00, 00, DateTimeKind.Local),
                End = new DateTime(2023, 6, 15, 10, 00, 00, DateTimeKind.Local),
            });
            travel.Items.Add(new LodgingEvent
            {
                Name = "Übernachtung Killarny",
                Lodging = new Lodging
                {
                    City = "Killarny",
                    Name = "The Wander Inn Bar & Accommodation",
                    Country = "Irland",
                    Street = "",
                    StreetNumber = "",
                    ZipCode = "",
                    TypeOfTarget = "Hotel"
                },
                Currency = "Euro",
                Price = 380,
                PriceForPersons = 0,
                Start = new DateTime(2023, 6, 15, 18, 00, 00, DateTimeKind.Local),
                End = new DateTime(2023, 6, 18, 10, 00, 00, DateTimeKind.Local),
            });
            travel.Items.Add(new LodgingEvent
            {
                Name = "Übernachtung Midleton",
                Lodging = new Lodging
                {
                    City = "Midleton",
                    Name = "An Stor Townhouse",
                    Country = "Irland",
                    Street = "",
                    StreetNumber = "",
                    ZipCode = "",
                    TypeOfTarget = "Hotel"
                },
                Currency = "Euro",
                Price = 95,
                PriceForPersons = 0,
                Start = new DateTime(2023, 6, 18, 18, 00, 00, DateTimeKind.Local),
                End = new DateTime(2023, 6, 19, 10, 00, 00, DateTimeKind.Local),
            });
            travel.Items.Add(new LodgingEvent
            {
                Name = "Übernachtung Kilkenny",
                Lodging = new Lodging
                {
                    City = "Kilkenny",
                    Name = "Kilkenny Hibernian",
                    Country = "Irland",
                    Street = "",
                    StreetNumber = "",
                    ZipCode = "",
                    TypeOfTarget = "Hotel"
                },
                Currency = "Euro",
                Price = 148,
                PriceForPersons = 0,
                Start = new DateTime(2023, 6, 19, 18, 00, 00, DateTimeKind.Local),
                End = new DateTime(2023, 6, 20, 10, 00, 00, DateTimeKind.Local),
            });
            travel.Items.Add(new LodgingEvent
            {
                Name = "Übernachtung Dublin",
                Lodging = new Lodging
                {
                    City = "Dublin",
                    Name = "Swuite Dublin Student Accommodation",
                    Country = "Irland",
                    Street = "Grangegorman Lower",
                    StreetNumber = "13-18",
                    ZipCode = "D07 YE81",
                    TypeOfTarget = "Hotel"
                },
                Currency = "Euro",
                Price = 148,
                PriceForPersons = 0,
                Start = new DateTime(2023, 6, 20, 18, 00, 00, DateTimeKind.Local),
                End = new DateTime(2023, 6, 23, 10, 00, 00, DateTimeKind.Local),
            });
            return travel;
        }

    }
}