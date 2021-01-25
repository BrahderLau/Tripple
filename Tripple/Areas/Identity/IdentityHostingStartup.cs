using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tripple.Areas.Identity.Data;
using Tripple.Data;

[assembly: HostingStartup(typeof(Tripple.Areas.Identity.IdentityHostingStartup))]
namespace Tripple.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TrippleContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TrippleContextConnection")));

                services.AddDefaultIdentity<TrippleUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TrippleContext>();
            });
        }
    }
}