using BuscaCnpjMvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BuscaCnpjMvc.Data;
using Microsoft.AspNetCore.Mvc;
using Refit;
using BuscaCnpjMvc.Services.Apis;
using BuscaCnpjMvc.Services.Apis.Refit;
using BuscaCnpjMvc.Services.Interfaces;
using BuscaCnpjMvc.Services;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BuscaCnpjMvcContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("BuscaCnpjMvcContext"), 
    ServerVersion.Parse("8.0.41"),
    builder => builder.MigrationsAssembly("BuscaCnpjMvc")));


builder.Services.AddControllersWithViews();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
builder.Services.AddScoped<ICnpjService, CnpjService>();
builder.Services.AddRefitClient<ICnpjApiRefit>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://www.receitaws.com.br/"));
builder.Services.AddEndpointsApiExplorer();

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
app.UseAuthorization();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
