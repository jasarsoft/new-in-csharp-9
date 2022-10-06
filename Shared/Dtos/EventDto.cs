using System;
using Shared.Enums;

namespace Shared.Dtos
{
    public abstract class DtoBase
    {
        protected DtoBase(int id, DateTimeOffset date, string name, EventType eventType, string venue)
        {
            Id = id;
            Date = date;
            Name = name;
            EventType = eventType;
            Venue = venue;
        }

        public int Id { get; init; }
        public DateTimeOffset Date { get; init; }
        public string Name { get; init; }
        public EventType EventType { get; init; }
        public string Venue { get; init; }
    }

    public class EventPriceDto : DtoBase
    {
        public EventPriceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue,
            int percentageSold, int ticketPrice) : base(id, date, name, eventType, venue)
        {
            PercentageSold = percentageSold;
            TicketPrice = ticketPrice;
        }

        public int PercentageSold { get; init; }
        public int TicketPrice { get; init; }

        public void Deconstruct(out int id, out DateTimeOffset date, out string name, out EventType eventType,
            out string venue, out int percentageSold, out int ticketPrice)
        {
            id = Id;
            date = Date;
            name = Name;
            eventType = EventType;
            venue = Venue;
            percentageSold = PercentageSold;
            ticketPrice = TicketPrice;
        }
    }

    public class EventDto : DtoBase
    {
        protected EventDto(int id, DateTimeOffset date, string name, EventType eventType, string venue,
            CostType venueCostType, CostType marketingCostType, int capacity, int sold) : base(id, date, name,
            eventType, venue)
        {
            VenueCostType = venueCostType;
            MarketingCostType = marketingCostType;
            Capacity = capacity;
            Sold = sold;
        }

        public int Capacity { get; init; }
        public int Sold { get; init; }
        public CostType VenueCostType { get; init; }
        public CostType MarketingCostType { get; init; }
    }

    public class ConferenceDto : EventDto
    {
        public ConferenceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue,
            CostType venueCostType, CostType marketingCostType, int capacity, int sold, int badgeCosts,
            int cateringCosts) : base(id, date,
            name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            BadgeCosts = badgeCosts;
            CateringCosts = cateringCosts;
        }

        public int BadgeCosts { get; init; }
        public int CateringCosts { get; init; }
    }

    public class MultiDayConferenceDto : ConferenceDto
    {
        public MultiDayConferenceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue,
            CostType venueCostType, CostType marketingCostType, int capacity, int sold, int badgeCosts,
            int cateringCosts, int numberOfDays,
            CostType accomodationCostType) : base(id, date, name, eventType, venue, venueCostType, marketingCostType,
            capacity, sold,
            badgeCosts, cateringCosts)
        {
            NumberOfDays = numberOfDays;
            AccomodationCostType = accomodationCostType;
        }

        public int NumberOfDays { get; init; }
        public CostType AccomodationCostType { get; init; }
    }

    public class ConcertDto : EventDto
    {
        public ConcertDto(int id, DateTimeOffset date, string name, EventType eventType, string venue,
            CostType venueCostType, CostType marketingCostType, int capacity, int sold, int artistCosts,
            CostType artistCostType) : base(id,
            date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            ArtistCosts = artistCosts;
            ArtistCostType = artistCostType;
        }

        public int ArtistCosts { get; init; }
        public CostType ArtistCostType { get; init; }
    }

    public class SportsGameDto : EventDto
    {
        public SportsGameDto(int id, DateTimeOffset date, string name, EventType eventType, string venue,
            CostType venueCostType, CostType marketingCostType, int capacity, int sold, int numberOfPlayers,
            int costsPerPlayer) : base(id,
            date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            NumberOfPlayers = numberOfPlayers;
            CostsPerPlayer = costsPerPlayer;
        }

        public int NumberOfPlayers { get; init; }
        public int CostsPerPlayer { get; init; }
    }
}