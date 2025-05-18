//Use - Scaffold-DbContext "Name=ConnectionStrings:EFDBCon" Microsoft.EntityFrameworkCore.SqlServer
//Scaffold-DbContext "Name=ConnectionStrings:EFDBCon" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Data

using EFDatabaseFirstDemo.Data;

var builder = WebApplication.CreateBuilder(args);

//Database settings
builder.Services.AddDbContext<TestEfdatabaseApprochContext>();

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
