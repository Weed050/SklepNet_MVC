using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SklepNet_MVC.Data;
using SklepNet_MVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SklepNetDBContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("SklepNetMVC_ConnectionString")));



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var dbContext = services.GetRequiredService<SklepNetDBContext>();
        dbContext.Database.Migrate(); // Wykonuje migracje bazy danych, je�li s� dost�pne
        SampleData.Initialize(services); // Dodaj to wywo�anie inicjalizacji
    }
    catch (Exception ex)
    {
        // Obs�u� ewentualne b��dy inicjalizacji bazy danych
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while initializing the database.");
    }
}

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
