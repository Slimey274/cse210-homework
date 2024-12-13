using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "62704");
        Address address2 = new Address("456 Elm St", "Metropolis", "NY", "10101");
        Address address3 = new Address("789 Oak St", "Gotham", "NJ", "07001");

        Lecture lecture = new Lecture("AI and the Future", "A talk on AI trends.", "2024-12-20", "10:00 AM", address1, "Dr. John Doe", 100);
        Reception reception = new Reception("Networking Night", "Meet professionals in your field.", "2024-12-22", "6:00 PM", address2, "rsvp@events.com");
        Outdoor outdoor = new Outdoor("Community Picnic", "Enjoy a day outdoors.", "2024-12-25", "12:00 PM", address3, "Sunny, 75°F");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt is Lecture l ? l.GetFullDetails() : evt is Reception r ? r.GetFullDetails() : ((Outdoor)evt).GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription(evt.GetType().Name));
            Console.WriteLine(new string('-', 50));
        }
    }   
}