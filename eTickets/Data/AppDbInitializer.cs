using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if(context.Cinemas.Any())
                {

                }
                //Actor
                if(context.Actors.Any())
                {

                }
                //Movie
                if(context.Movies.Any())
                {

                }
                //Producer
                if(context.Producers.Any())
                {

                }
                //Actor_Movie
                if(context.Actor_Movies.Any())
                {

                }
            }
        }
    }
}
