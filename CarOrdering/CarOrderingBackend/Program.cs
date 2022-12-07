using Microsoft.EntityFrameworkCore;
using CarOrderingBackend;
using CarOrderingBackend.Interfaces;
using CarOrderingBackend.Data;
using CarOrderingBackend.Repositories;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// what does this do
builder.Services.AddControllers();

// Configures swagger for generating 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ICarModelRepository, CarModelRepository>();
builder.Services.AddScoped<IPaintRepository, PaintRepository>();
builder.Services.AddScoped<IRimsRepository, RimsRepository>();
builder.Services.AddScoped<ITyresRepository, TyresRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlite(configuration.GetConnectionString("CarDatabase")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGraphQL("/graphql");
app.Run();

