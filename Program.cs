using Microsoft.EntityFrameworkCore;
using MyFirstWebApp.Data;

// application builder setup
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add Entity Framework services
builder.Services.AddDbContext<MyFirstWebApp.Data.ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

// Redirect root URL to Journal page
app.MapGet("/", () => Results.Redirect("/Journal"));

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
