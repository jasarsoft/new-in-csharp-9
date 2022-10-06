namespace ExperimentsWithRecords
{
    public record PersonDto(string Name)
    {
        public string City { get; set; }

        public PersonDto() : this("Empty")
        {
            
        }

        public void Deconstruct(out string name, out string city)
        {
            name = Name;
            city = City;
        }

        public void SomeMethod()
        {

        }
    }
}
