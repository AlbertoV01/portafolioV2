namespace portafolioV2.Models
{
    public class TechIcon
    {
        public string Name { get; set; } = String.Empty;
        public string IconUrl { get; set; } = String.Empty;
    }

    public class ProjectItem
    {
        public string Title { get; set; } = String.Empty;
        public string ShortDescription { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public string GitUrl { get; set; } = String.Empty;
        public string DemoUrl { get; set; } = String.Empty;
        public List<TechIcon> Technologies { get; set; } = new();
    }
}
