namespace Task10.Models
{
    public class Travel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string DestinationCountry { get; set; }
        public int Budget { get; set; }
        public Travel(string name, string secondName, string lastName, string phoneNumber, string destinationCountry, int budget)
        {
            Name = name;
            SecondName = secondName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DestinationCountry = destinationCountry;
            Budget = budget;
        }
    }
}
