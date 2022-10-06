using Shared.Dtos;
using Shared.Enums;
using System;

namespace ExperimentsWithRecords
{
    internal class Program
    {
        public record EventPriceDtoToo(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue,
                int PercentageSold, int TicketPrice)
            : EventPriceDto(Id, Date, Name, EventType, Venue, PercentageSold, TicketPrice);

        static void Main(string[] args)
        {
            var now = DateTimeOffset.Now;
            EventPriceDto dto = new(1, now, "Test", EventType.Concert, "Music hall", 80, 100);
            EventPriceDto dto2 = new(1, now, "Test", EventType.Concert, "Music hall", 80, 100);
            EventPriceDtoToo dtoToo = new(1, now, "Test", EventType.Concert, "Music hall", 80, 100);

            var dto3 = dto with { Name = "Concert" };
            DtoBase dto4 = dto with { Name = "Concert" };
            var isEventPrice = dto4 is EventPriceDto;

            Console.WriteLine($"dto: {dto}");
            Console.WriteLine($"dto == dto2: {dto == dto2}");
            Console.WriteLine($"dto == dtoToo: {dto == dtoToo}");
            Console.WriteLine($"dto3: {dto3}");
            Console.WriteLine($"isEventPrice: {isEventPrice}");
        }
    }
}
