namespace App.Data.Entity.Yedek
{
    public class DoctorEducation
    {
        public int Id { get; set; }
        public User Doctor { get; set; }
        public int DoctorId { get; set; }
        public string Year { get; set; }
        public string School { get; set; }
        public string Detail { get; }
    }
}
