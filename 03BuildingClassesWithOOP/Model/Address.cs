namespace Assignment3
{
    public class Address
    {
        public int Id { get; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(int id, string streetName, string city, string state, string zipCode)
        {
            Id = id;
            StreetName = streetName;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
