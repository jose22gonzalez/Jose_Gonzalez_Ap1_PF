using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Jose_Gonzalez_Ap1_PF.Data;
using Jose_Gonzalez_Ap1_PF.DAL;
using Jose_Gonzalez_Ap1_PF.BBL;
using Microsoft.EntityFrameworkCore;
using Blazored.Toast;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddBlazoredToast();

builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ConStr"))
    );

builder.Services.AddTransient<InscripcionesBBL>();
builder.Services.AddTransient<GruposBBL>();
builder.Services.AddTransient<ProfesoresBBL>();
builder.Services.AddTransient<EstudianteBBL>();
builder.Services.AddTransient<CursoBBL>();
builder.Services.AddTransient<AulasBBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
