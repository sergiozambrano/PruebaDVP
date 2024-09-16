using Microsoft.EntityFrameworkCore;
using PruebaDVP.Context;
using PruebaDVP.Infrastructure.Interface;
using PruebaDVP.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("Conexion");

builder.Services.AddDbContext<PruebaDvpContext>(option =>
        option.UseSqlServer(connection)
);

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
