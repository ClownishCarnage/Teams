using ClownishCarnage.TeamsSSO.Mvc;

var appBuilder = WebApplication.CreateBuilder(args)
    .RegisterServices()
    .AuthenticationServices();

// Add services to the container.
appBuilder.Services.AddControllersWithViews();

var app = appBuilder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.SetupMiddleware().Run();

