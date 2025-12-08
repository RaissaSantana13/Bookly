
using AutoMapper;
using Bookly.App.Others;
using Bookly.App.Register;
using Bookly.App.ViewModel;
using Bookly.Domain.Base;
using Bookly.Domain.Base;
using Bookly.Domain.Entities;
using Bookly.Repository.Context;
using Bookly.Repository.Repository;
using Bookly.Repository.Repository;
using Bookly.Service.Service;
using Bookly.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net.NetworkInformation;

namespace Bookly.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;
        public static void ConfigureServices()
        {
            // data base config
            var dbConfigFile = "Config/DbConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<BooklyContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );

            #region Repository
            services.AddScoped<IBaseRepository<Author>, BaseRepository<Author>>();
            services.AddScoped<IBaseRepository<Book>, BaseRepository<Book>>();
            services.AddScoped<IBaseRepository<Genre>, BaseRepository<Genre>>();
            services.AddScoped<IBaseRepository<ReadingProcess>, BaseRepository<ReadingProcess>>();
            services.AddScoped<IBaseRepository<ReadingSession>, BaseRepository<ReadingSession>>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            #endregion

            #region Service
            services.AddScoped<IBaseService<Author>, BaseService<Author>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<Genre>, BaseService<Genre>>();
            services.AddScoped<IBaseService<ReadingProcess>, BaseService<ReadingProcess>>();
            services.AddScoped<IBaseService<ReadingSession>, BaseService<ReadingSession>>();
            services.AddScoped<IBaseService<Book>, BaseService<Book>>();


            #endregion

            #region Forms
            services.AddScoped<RegisterUserForm, RegisterUserForm>();
            services.AddScoped<AuthorForm, AuthorForm>();
            services.AddScoped<BookForm, BookForm>();
            services.AddScoped<ReadingSessionForm, ReadingSessionForm>();

            services.AddTransient<LoginForm>();
            #endregion


            services.AddSingleton(
                new MapperConfiguration(
                    config => {
                        config.CreateMap<User, UserViewModel>();
                        config.CreateMap<Author, AuthorViewModel>();
                        config.CreateMap<Book, BookViewModel>();
                        config.CreateMap<ReadingSession, ReadingSessionViewModel>();
                        config.CreateMap<Genre, GenreViewModel>();
                        config.CreateMap<ReadingProcess, ReadingProcessViewModel>();

                        config.CreateMap<ReadingSession, ReadingSessionViewModel>().ReverseMap();

                        config.CreateMap<Genre, GenreViewModel>().ReverseMap();
                        config.CreateMap<ReadingProcess, ReadingProcessViewModel>().ReverseMap();
                    },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            serviceProvider = services.BuildServiceProvider();

        }
    }
}
