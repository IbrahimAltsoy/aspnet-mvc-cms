namespace App.Data.Entity
{
    public class CategoryPost
    {
        public int Id { get; set; }


        public int? PostId { get; set; }
        public Post? Post { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
