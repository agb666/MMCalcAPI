using Microsoft.Data.Sqlite;
using MMCalc.Repos;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var sqlConBuilder = new SqliteConnectionStringBuilder();
//sqlConBuilder.ConnectionString = builder.Configuration.GetConnectionString("SqlLiteDatabase");
//builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(sqlConBuilder.ConnectionString));


builder.Services.AddScoped<ICalc, Calc>();

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
