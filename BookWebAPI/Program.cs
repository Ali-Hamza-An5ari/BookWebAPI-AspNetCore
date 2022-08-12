using BookWebAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//HTTP Pipeline. Only added Services will be seen or called by the API project

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BooksDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"))
    );
//dependency Injection which allows us to use our DbContext throughout the project. We can use our BooksDbCOntext Which is in Data anyhwhere like in controllers because of dependency injection
    
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
