namespace BookStore.Models
{
    public partial class Category
    {
        public Category() { }

        public Category(string Id, string CategoryName, int Established_year, string description) 
        {
            id = Id;
            Categoryname = CategoryName;
            Establishedyear = Established_year;
            Description = description;
        }
        public string id { get; set; } = string.Empty;
        public string Categoryname { get; set; } = string.Empty;
        public int Establishedyear { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
