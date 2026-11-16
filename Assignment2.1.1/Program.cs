//Assignment2.1.1
//Design a class hierarchy of your choice. (Need only class files)
//Example: Business -> Hospitality 
// Hospitality -> Resort, Hotel, Motel, etc.
class Business
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Business(string name, string address)
    {
        Name = name;
        Address = address;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Business Name: {Name}, Address: {Address}");
    }
}

class Hospitality : Business
{
    public int NumberOfRooms { get; set; }
    public Hospitality(string name, string address, int numberOfRooms) : base(name, address)
    {
        NumberOfRooms = numberOfRooms;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Rooms: {NumberOfRooms}");
    }
}
class Resort : Hospitality
{
    public int Amenities { get; set; }
    public Resort(string name, string address, int numberOfRooms, int amenities) : base(name, address, numberOfRooms)
    {
        Amenities = amenities;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Total Amenities: {Amenities}");
    }
}

class Hotel : Hospitality
{
    public int StarRating { get; set; }
    public Hotel(string name, string address, int numberOfRooms, int starRating) : base(name, address, numberOfRooms)
    {
        StarRating = starRating;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Star Rating: {StarRating}");
    }
}
class Program
{
    static void Main()
    {
        Business business = new Business("Fairmont", "Bellustar");
        business.DisplayInfo();
        Hospitality hospitality = new Hospitality("Grand Hospitality", "Luxury Lane", 100);
        hospitality.DisplayInfo();
        Resort resort = new Resort("Beach Resort", "Tropical Coast", 50, 20);
        resort.DisplayInfo();
        Hotel hotel = new Hotel("Grand Hotel", "Luxury Lane", 100, 5);
        hotel.DisplayInfo();
    }
}