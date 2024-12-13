using System;

public class Outdoor : Event
{
        private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + "\n" +
               $"Event Type: Outdoor Gathering\n" +
               $"Weather: {_weather}";
    }
}