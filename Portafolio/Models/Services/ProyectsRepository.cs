namespace Portafolio.Models.Services
{

    public interface IProyectsRepository
    {
        List<Proyect> GetProyects();
    }

    public class ProyectsRepository : IProyectsRepository
    {

        public List<Proyect> GetProyects()
        {
            return new List<Proyect>() {
                new Proyect(){ Title = "Amazon", Description = "E-Commerce realizado en ASP.NET Core", Link = "https://www.amazon.com.mx", ImagenUrl = "/img/amazon.png" },
                new Proyect(){ Title = "New York Times", Description = "Página de noticias en React", Link = "https://www.nytimes.com", ImagenUrl = "/img/nyt.png" },
                new Proyect(){ Title = "Reddit", Description = "Red socual para compartir en comunidades", Link = "https://www.reddit.com", ImagenUrl = "/img/reddit.png" },
                new Proyect(){ Title = "Steam", Description = "Tienda en línea para comprar videojuegos", Link = "https://store.steampowered.com/", ImagenUrl = "/img/steam.png" },
            };
        }

    }
}
