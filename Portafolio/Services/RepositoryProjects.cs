using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IRepositoryProjects
    {
        List<Proyect> GetProjects();
    }

    public class RepositoryProjects : IRepositoryProjects
    {
        public List<Proyect> GetProjects()
        {
            return new List<Proyect>()
            {
                new Proyect
                {
                    Title = "Project 1",
                    Description = "list and create an E-comerce with ASP.NET Core",
                    Link = "http://example.com",
                    ImageURL = "/images/amazon.png"
                },
                new Proyect
                {
                    Title = "Project 2",
                    Description = "list and create an E-comerce with ASP.NET Core",
                    Link = "http://example.com",
                    ImageURL = "/images/nyt.png"
                },
                new Proyect
                {
                    Title = "Project 3",
                    Description = "list and create an E-comerce with ASP.NET Core",
                    Link = "http://example.com",
                    ImageURL = "/images/reddit.png"
                }
            };
        }
    }
}
