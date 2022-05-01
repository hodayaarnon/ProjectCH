using DAL.Classes;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection ser, IConfiguration con)
        {
            ser.AddScoped<ICommunitiesRepository, CommunitiesRepository>();
            ser.AddScoped<IUsersRepository, UsersRepository>();
            ser.AddScoped<IRolesRepository, RolesRepository>();
            ser.AddScoped<IAskstojoinRepositpry, AskstojoinRepositpry>();
            ser.AddDbContext<DBContext>(options => options.UseSqlServer("Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID=transportsdb;Password=Lq1f7C-BGo~N"));
            return ser;
        }
    }
}
