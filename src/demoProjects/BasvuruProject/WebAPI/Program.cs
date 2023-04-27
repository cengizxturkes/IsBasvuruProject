using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence;
using Persistence.Contexts;
using MediatR;
using Application;
using Core.CrossCuttingConcerns.Exceptions;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Core.Application.Pipelines.Caching;
using Microsoft.OpenApi.Models;
using static Org.BouncyCastle.Math.EC.ECCurve;
using Core.Application.Pipelines.Logging;
using Application.Services;

var builder = WebApplication.CreateBuilder(args); 
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSecurityServices();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();
builder.Services.Configure<CacheSettings>(builder.Configuration.GetSection("CacheSettings"));
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MediatRReponseCaching", Version = "v9" });
});
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddAuthentication();
//builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwaggerUI(c => { c.DisplayRequestDuration(); c.SwaggerEndpoint("/swagger/v1/swagger.json", "MediatRReponseCaching v1"); });
if (app.Environment.IsProduction())
    app.ConfigureCustomExceptionMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();

