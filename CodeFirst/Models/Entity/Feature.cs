namespace CodeFirst.Models.Entity
{
    public class Feature
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string URL { get; set; }
        public int Seq { get; set; }

        public string CSSClass { get; set; }
        public Boolean isVisible { get; set; }
        public int Parentld { get; set; }
        public Auth Auth { get; set; }
    }

}
