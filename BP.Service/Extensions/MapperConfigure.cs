using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Service.Extensions
{
    public static class MapperConfigure
    {
        public static void AddMapperConfigure(this IServiceCollection services)
        {
            var mapperconfig = new MapperConfiguration(i => i.AddProfile(new AutoMapperProfile()));

            IMapper mapper=mapperconfig.CreateMapper();
            services.AddSingleton(mapper);


        }
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile() {
                CreateMap<BP.Models.Contact, BP.Data.Model.ContactDVO>()
                        .ForMember(x => x.FullName, y => y.MapFrom(z => z.FirsName + " " + z.LastName))
                      .ReverseMap();            
            }
        }
    }
}
