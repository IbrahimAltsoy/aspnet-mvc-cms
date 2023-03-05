namespace App.Data.Entity
{
    public class Setting
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public User User { get; set; }
    }
}
