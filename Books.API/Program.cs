using Books.Api.DbContexts;
using Books.API.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//builder.Services.AddDbContext<BookDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:BooksDBConnectionString"]));
builder.Services.AddDbContext<BookDbContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:BooksDBConnectionString"])
           .EnableSensitiveDataLogging(); // Enable sensitive data logging
});


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IBookRepo, BookRepo>();

//builder.Services.AddAuthentication("Bearer")
//    .AddJwtBearer(options =>
//    {
//        options.TokenValidationParameters = new()
//        {
//            ValidateIssuer = true,
//            ValidateAudience = true,
//            ValidateIssuerSigningKey = true,
//            ValidIssuer = builder.Configuration["Authentication:Issuer"],
//            ValidAudience = builder.Configuration["Authentication:Audience"],
//            IssuerSigningKey = new SymmetricSecurityKey(
//                Encoding.ASCII.GetBytes(builder.Configuration["Authentication:SecretForKey"]))
//        };
//    }
//    );

var app = builder.Build();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
