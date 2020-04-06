using System;
using Data;
using Instruments.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Instruments.Areas.Identity.IdentityHostingStartup))]
namespace Instruments.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<InstrumentsContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("InstrumentsContextConnection")));

              //  services.AddDefaultIdentity<InstrumentsUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<InstrumentsContext>();
            });
        }
    }
}