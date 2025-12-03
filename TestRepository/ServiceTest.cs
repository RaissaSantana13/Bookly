using AutoMapper;
using Bookly.Domain.Base;
using Bookly.Domain.Entities;
using Bookly.Repository.Context;
using Bookly.Repository.Repository;
using Bookly.Service.Service;
using Bookly.Service.Validatorrs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Text.Json;

namespace Bookly.Test
{
    [TestClass]
    public sealed class ServiceTest
    {
        private ServiceCollection services;
        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<BooklyContext>();
            services.AddScoped<IBaseRepository<Genre>, BaseRepository<Genre>>();
            services.AddScoped<IBaseService<Genre>, BaseService<Genre>>();
            services.AddSingleton(
                new MapperConfiguration(
                    config => { config.CreateMap<Genre, Genre>(); },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            return services.BuildServiceProvider();

        }
        [TestMethod]
        public void TestGenreService()
        {
            var serviceProvider = ConfigureServices();
            var _genreService = serviceProvider.GetService<IBaseService<Genre>>();
            var genre = new Genre { Name = "Romance" };
            var result = _genreService.Add<Genre, Genre, GenreValidator>(genre);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}