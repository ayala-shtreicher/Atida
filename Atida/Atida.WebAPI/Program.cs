using Atida.Context;
using Atida.Repositories.Intefaces;
using Atida.Repositories.Repositories;
using Atida.Services.Interfaces;
using Atida.Services.Services;
using Atida.WebAPI;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IContext, MyDbContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Mapping));


var app = builder.Build();

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
