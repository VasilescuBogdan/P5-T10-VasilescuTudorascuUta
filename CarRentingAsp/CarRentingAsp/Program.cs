using CarRentingAsp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Services;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Repositories;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<CarRentingContext>();
builder.Services.AddIdentityCore<User>().AddRoles<IdentityRole>()
               .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<User, IdentityRole>>()
               .AddEntityFrameworkStores<CarRentingContext>().AddDefaultTokenProviders();
builder.Services.AddDbContext<CarRentingContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("CarRentDb")));

builder.Services.AddScoped<IRepositoryWrapper,RepositoryWrapper>();

builder.Services.AddScoped<AnswerService>();
builder.Services.AddScoped<BookingService>();
builder.Services.AddScoped<Car_CategoryService>();
builder.Services.AddScoped<CarService>();
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<RespondService>();
builder.Services.AddScoped<ReviewService>();


builder.Services.AddScoped<IAnswerRepository,AnswerRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<ICar_CategoryRepository,Car_CategoryRepository>();
builder.Services.AddScoped<ICarRepository,CarRepository>();
builder.Services.AddScoped<IContactRepository,ContactRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRespondRepository,RespondRepository>();
builder.Services.AddScoped<IReviewRepository,ReviewRepository>();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = false;
    options.Password.RequiredUniqueChars = 6;

    // Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
    options.Lockout.MaxFailedAccessAttempts = 10;
    options.Lockout.AllowedForNewUsers = true;

    // User Settings
    options.User.RequireUniqueEmail = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();



app.UseRouting();
app.UseAuthentication();;
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CarRentingGuest}/{action=IndexGuest}/{id?}");
app.MapRazorPages();
app.Run();
