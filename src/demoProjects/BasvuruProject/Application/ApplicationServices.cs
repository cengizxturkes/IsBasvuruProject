using Application.Services;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Validation;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ApplicationService
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(c =>
            {
                c.RegisterServicesFromAssembly(assembly);
                c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                c.AddOpenBehavior(typeof(AuthorizationBehavior<,>));
                c.AddOpenBehavior(typeof(CachingBehavior<,>));
                c.AddOpenBehavior(typeof(CacheRemovingBehavior<,>));
                c.AddOpenBehavior(typeof(LoggingBehavior<,>));
                c.AddOpenBehavior(typeof(RequestValidationBehavior<,>));


            }); ; ;
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheRemovingBehavior<,>));
            services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            services.AddSingleton<IMailQueue,MailSenderBackgroundService>();
            services.AddSingleton<IMailService, MailService>();
            services.AddHostedService<MailSenderBackgroundService>();

            return services;

        }
    }
}
