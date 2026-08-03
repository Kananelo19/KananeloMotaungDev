namespace KananeloMotaungDev.Models
{
    // A model represents the structure of one portfolio project.
    // Every project object must follow this same shape.
    public class Project
    {
        // Project name shown on the portfolio card.
        public string Title { get; set; } = string.Empty;

        // Short explanation of the problem and solution.
        public string Description { get; set; } = string.Empty;

        // Technologies used to build the project.
        public List<string> Technologies { get; set; } = new();

        // Relative path to the project image inside wwwroot.
        public string ImagePath { get; set; } = string.Empty;

        // GitHub repository URL.
        public string GitHubUrl { get; set; } = string.Empty;

        // Optional live website or demo URL.
        // The question mark means this value is allowed to be null.
        public string? LiveUrl { get; set; }

        // Controls whether this project receives the featured layout.
        public bool IsFeatured { get; set; }
    }
}