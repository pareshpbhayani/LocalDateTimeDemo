// See https://aka.ms/new-console-template for more information
DateTime localTime = DateTime.Now;
Console.WriteLine($"Local DateTime: {localTime}");

DateTime utcTime = localTime.ToUniversalTime();
Console.WriteLine($"UTC DateTime: {utcTime}");

DateTimeOffset localTimeOffset = DateTimeOffset.Now;
Console.WriteLine($"Local DateTime with Offset: {localTimeOffset}");