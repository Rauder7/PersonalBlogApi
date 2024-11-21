namespace Domain.ValueObjects
{
    internal class Author
    {
        string Name { get; set; }
        public string? Description { get; set; }

        public Author(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public static Author Create(string name, string? description)
        {
            return new(name, description);
        }
    }
}