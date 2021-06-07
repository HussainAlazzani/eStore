namespace Core.Entities.OrderAggregate
{
    /// <summary>
    /// This is a value entity because it is going to be owned by the order entity,
    /// hence no id. In other words this address will be added as columns to the order table.
    /// </summary>
    public class Address
    {
        // EF requires an empty constructor.
        public Address()
        {
        }

        public Address(string firstName, string lastName, string street, string city, string state, string zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}