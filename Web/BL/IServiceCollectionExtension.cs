using AutoMapper;
using BL.Profiles;
using BL.Services;
using DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public static class IServiceCollectionExtension
    {
        //configuration of Microsoft.Extensions.Configuration, not auto mapper
        public static IServiceCollection AddServices(this IServiceCollection ser, IConfiguration con)
        {
            ser.AddScoped<ICommunitiesService, CommunitiesService>();
            ser.AddScoped<IUsersService, UsersService>();
            ser.AddScoped<IRolesService, RolesService>();
            ser.AddScoped<IAskstojoinService, AskstojoinService>();
           // ser.AddScoped<IUsersService, UsersService>();
            
            ser.AddAutoMapper(typeof(CommunitiesProfile));
            ser.AddAutoMapper(typeof(UsersProfile));
            ser.AddAutoMapper(typeof(RolesProfile));
            ser.AddAutoMapper(typeof(AskstojoinService));
            //ser.AddAutoMapper(typeof(CustomersProfile));
            //ser.AddAutoMapper(typeof(ClothesProfile));
            ser.AddRepositories(con);
            return ser;
        }
    }
}
