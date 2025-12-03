
using AutoMapper;
using Bookly.Domain.Base;
using Bookly.Repository.Repository;
using Bookly.Service.Service;
//using Bookly.App.Register;
using Bookly.App.ViewModel;
using Bookly.Domain.Base;
using Bookly.Domain.Entities;
using Bookly.Repository.Context;
using Bookly.Repository.Repository;
using Bookly.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net.NetworkInformation;

namespace IFSPStore.app.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;
        public static void ConfigureServices()
        {
            // data base config
            var dbConfigFile = "Config/DBCOnfig.txt";
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
            //services.AddScoped<IBaseService<Author>, BaseService<Book>>();
            //services.AddScoped<IBaseService<User>, BaseService<User>>();
            #endregion

            #region Forms
            //services.AddTransistent<CategoryForm, CategoryForm>();
            //services.AddScoped<UserForm, UserForm>();
            #endregion


            /*services.AddSingleton(
                new MapperConfiguration(
                    config => {
                        config.CreateMap<User, UserViewModel>();
                        config.CreateMap<Category, CategoryViewModel>();
                    },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            serviceProvider = services.BuildServiceProvider();*/

        }
    }
}
