namespace CodeFirst.Models.Entity
{
    public class Auth
    {
        public int id { get; set; }
        public string AuthType { get; set; }

        public ICollection<Role> Roles { get; set; }
        public ICollection<Feature> Features { get; set; }
    }

}
