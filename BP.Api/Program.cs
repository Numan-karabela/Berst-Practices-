using BP.Api.Extensions;
using BP.Api.Validations;
using BP.Data.Model;
using BP.Service.Extensions;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 
builder.Services.AddService(builder.Configuration);
builder.Services.AddMapperConfigure();
builder.Services.AddValidationExtensions();


var app = builder.Build();

app.UseResponseCaching();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
