namespace CodeFirst.Models.Entity
{
    public class User
    {
        public int id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public bool IsValid { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpddateDateTime { get; set; }
        public int CreateUser { get; set; }
        public int UpdateUser { get; set; }

        public ICollection<Role> Roles { get; set; }
    }

}
