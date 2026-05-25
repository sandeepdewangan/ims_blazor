using IMS.Plugins.InMemory;
using IMS.WebApp.Components;
using MIS.UseCases.Inventories;
using MIS.UseCases.Inventories.Interface;
using MIS.UseCases.PluginInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();


// AddSingleton: Created once for entire application and Destroyed when app stops
builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();

// AddTransient: Created every time requested and Destroyed after use
builder.Services.AddTransient<IViewInventoriesByNameUseCase, ViewInventoriesByNameUseCase>();

// AddScoped: One instance per HTTP request

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>();

app.Run();
