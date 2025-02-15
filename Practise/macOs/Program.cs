using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using macOs.Components;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorComponents().AddInteractiveServerComponents();
// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddSingleton<macOs.Applications.AppList.App>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode(); // Corrected placement

app.Run();
