namespace CodeFirst.Models.Entity
{
    public class Role
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Boolean IsValid { get; set; }

        public DateTime CreateDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public int CreateUser { get; set; }
        public int UpdateUser { get; set; }
        public int RoleGroupId { get; set; }

        public ICollection<Auth> Auths { get; set; }

        public ICollection<User> Users { get; set; }
    }

}
