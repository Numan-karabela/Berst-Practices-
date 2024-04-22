using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Service.Extensions
{
    static public class ServiceRegistration
    {
        public static void AddService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IContactService, ContactService>();

        }
    }
}
