using Shared.Dtos;
using Shared.Enums;
using System;

namespace ExperimentsWithRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventPriceDto dto = new(1, DateTimeOffset.Now, "Test", EventType.Concert, "Music hall", 80, 100);
            Console.WriteLine($"{dto}");
        }
    }
}
