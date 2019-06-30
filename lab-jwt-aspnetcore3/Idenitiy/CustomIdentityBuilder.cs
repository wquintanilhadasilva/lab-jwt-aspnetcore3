using System;
using labjwt.aspnetcore3.Idenitiy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace labjwt.aspnetcore3.identity
{
    public static class CustomIdentityBuilder
    {

        //public static IdentityBuilder AddCustomIdentity(this IServiceCollection services)
        //{
        //    return services.AddIdentity<User, ApplicationRole>().AddUserStore<UserProvider<User>>();
        //}

        public static IdentityBuilder UseCustomIdentity(
           this IServiceCollection services)
        {
            return services.AddIdentity<User, ApplicationRole>().AddUserStore<UserProvider<User>>();
        }

        //public static IdentityBuilder AddIdentity<TUser, TRole>(
        //    this IServiceCollection services)
        //    where TUser : class
        //    where TRole : class
        //{
        //    return services.AddIdentity<TUser, TRole>(setupAction: null);
        //}
    }
}
