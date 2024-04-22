using BP.Api.Validations;
using BP.Data.Model;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace BP.Api.Extensions
{
    public static class ValidationExtension
    {
        public static void AddValidationExtensions(this IServiceCollection services)
        {

            services.AddTransient<IValidator<ContactDVO>, ContactValidations>();
            services.AddFluentValidation(p => p.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));


        }
    }
}
