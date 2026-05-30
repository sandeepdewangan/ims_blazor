using IMS.DataAccess;
using IMS.DataAccess.Interface;
using IMS.WebApp.Components;
using IMS.WebApp.Components.Account;
using IMS.WebApp.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityRedirectManager>();

builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

builder.Services.AddDbContext<IMSIdentityContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("IMSAccount")));

builder.Services.AddIdentityCore<ApplicationUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Stores.SchemaVersion = IdentitySchemaVersions.Version3;
    })
    .AddEntityFrameworkStores<IMSIdentityContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

builder.Services.AddDbContextFactory<IMSContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("InventoryManagement"));
});

if (builder.Environment.IsEnvironment("Testing"))
{
    StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

    // In memory test dataset
    //builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();

}
else
{
    // PgSQL Database
    // AddSingleton: Created once for entire application and Destroyed when app stops
    builder.Services.AddTransient<IInventoryRepository, InventoryRepository>();
    builder.Services.AddTransient<IProductRepository, ProductRepository>();
    builder.Services.AddTransient<IInventoryReportRepository, InventoryReportRepository>();
    // AddTransient: Created every time requested and Destroyed after use
    // AddScoped: One instance per HTTP request
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// This middleware called by page not found like... /inventories/asakjbhsdsd(anything)/sasa
// This is not like NotFound().
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
// Add Interactive SSR and also
// include this above
// builder.Services.AddRazorComponents().AddInteractiveServerComponents();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints(); ;

app.Run();
