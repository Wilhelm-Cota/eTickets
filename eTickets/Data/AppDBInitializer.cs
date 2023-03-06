using eTickets.Models;

namespace eTickets.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();

                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>() {
                        new Cinema()
                    {
                        Name = "Cinema 1",
                        Logo = "https://www.dreamstime.com/royalty-free-stock-photography-movies-film-cinema-movie-theater-image27668457",
                        Description = "This is the first Cinema"
                    },
                        new Cinema()
                    {
                        Name = "Cinema 2",
                        Logo = "https://www.dreamstime.com/royalty-free-stock-photography-movies-film-cinema-movie-theater-image27668457",
                        Description = "This is the first Cinema"
                    }
                    });
                    context.SaveChanges();
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() { 
                    new Actor() {
                        Id= 1,
                        FullName = "John",
                        Bio ="Movie actor and musician",
                        ProfilePictureURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.businessinsider.com%2Fmost-popular-actors-in-the-us-2018-4&psig=AOvVaw2_lRqblT2uxMB2IUgy49v-&ust=1677937681056000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCNCGwPjxv_0CFQAAAAAdAAAAABAJ"
                    },
                     new Actor() {
                         Id= 2,
                        FullName = "mark",
                        Bio ="Movie actor and musician",
                        ProfilePictureURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.businessinsider.com%2Fmost-popular-actors-in-the-us-2018-4&psig=AOvVaw2_lRqblT2uxMB2IUgy49v-&ust=1677937681056000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCNCGwPjxv_0CFQAAAAAdAAAAABAJ"
                    }
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Batman",
                            Description = "The story of the batman",
                            Price = 39.5,
                            StartDate=  DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ImageURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic1.srcdn.com%2Fwordpress%2Fwp-content%2Fuploads%2F2023%2F01%2Fscreenrant-best-movies-all-time-dark-knight-my-left-foot-toy-story-lord-of-the-rings-pans-labyrinth-godfather-casablanca-psycho.jpg&imgrefurl=https%3A%2F%2Fscreenrant.com%2Fbest-movies-of-all-time-ranked-imdb%2F&tbnid=e_rSGeDSO2hzWM&vet=12ahUKEwjqzM-V9L_9AhU5sScCHW37CCgQMygJegUIARD8AQ..i&docid=Ti5O03d3U_IleM&w=2000&h=1000&q=image%20of%20movies&ved=2ahUKEwjqzM-V9L_9AhU5sScCHW37CCgQMygJegUIARD8AQ",
                            ProducerId= 1,
                            movieCategory = Enums.MovieCategory.Action
                        },
                         new Movie()
                        {
                            Name = "The Batman",
                            Description = "The story of the batman",
                            Price = 39.5,
                            StartDate=  DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 2,
                            ImageURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic1.srcdn.com%2Fwordpress%2Fwp-content%2Fuploads%2F2023%2F01%2Fscreenrant-best-movies-all-time-dark-knight-my-left-foot-toy-story-lord-of-the-rings-pans-labyrinth-godfather-casablanca-psycho.jpg&imgrefurl=https%3A%2F%2Fscreenrant.com%2Fbest-movies-of-all-time-ranked-imdb%2F&tbnid=e_rSGeDSO2hzWM&vet=12ahUKEwjqzM-V9L_9AhU5sScCHW37CCgQMygJegUIARD8AQ..i&docid=Ti5O03d3U_IleM&w=2000&h=1000&q=image%20of%20movies&ved=2ahUKEwjqzM-V9L_9AhU5sScCHW37CCgQMygJegUIARD8AQ",
                            ProducerId= 2,
                            movieCategory = Enums.MovieCategory.Action
                      
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.producers.Any())
                {
                    context.producers.AddRange(new List<Producer>() {
                    new Producer() {
                       
                        FullName = "John",
                        Bio ="Movie actor and musician",
                        ProfilePictureURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.businessinsider.com%2Fmost-popular-actors-in-the-us-2018-4&psig=AOvVaw2_lRqblT2uxMB2IUgy49v-&ust=1677937681056000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCNCGwPjxv_0CFQAAAAAdAAAAABAJ"
                    },
                     new Producer() {
                         
                        FullName = "mark",
                        Bio ="Movie actor and musician",
                        ProfilePictureURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.businessinsider.com%2Fmost-popular-actors-in-the-us-2018-4&psig=AOvVaw2_lRqblT2uxMB2IUgy49v-&ust=1677937681056000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCNCGwPjxv_0CFQAAAAAdAAAAABAJ"
                    }
                    });
                    context.SaveChanges();
                }
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie() {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie() {
                            ActorId = 2,
                            MovieId = 2
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
