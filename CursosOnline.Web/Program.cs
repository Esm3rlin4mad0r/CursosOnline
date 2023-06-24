using CursosOnline.Data;
using CursosOnline.Web.ApiServices.Interfaces;
using CursosOnline.Web.ApiServices.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient();

builder.Services.AddSingleton(new DbContext1(builder.Configuration.GetConnectionString("conexion")));

builder.Services.AddTransient<IProductApiService, ProductApiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cuenta}/{action=Login}/{id?}");

app.Run();
