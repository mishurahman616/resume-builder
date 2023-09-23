using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ResumeBuilder.Persistence;
using ResumeBuilder.Web;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((hostBuilderContext, loggerConnfiguration) =>
{
    loggerConnfiguration.MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .ReadFrom.Configuration(builder.Configuration);
});
try
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
        ?? throw new InvalidOperationException("Connection String Not Found!");
    var migrationsAssembly = Assembly.GetExecutingAssembly().FullName;
    // Add services to the container.
    builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
    builder.Host.ConfigureContainer<ContainerBuilder>(cb =>
    {
        cb.RegisterModule(new WebModule());
        cb.RegisterModule(new PersistenceModule(connectionString, migrationsAssembly!));
    });
    builder.Services.AddControllersWithViews();
    builder.Services.AddDbContext<ApplicationDbContext>(dbContextOptionsBuilder =>
    {
        dbContextOptionsBuilder.UseSqlServer(
            connectionString,
            sqlServerDbCtxtOpBuilder => sqlServerDbCtxtOpBuilder.MigrationsAssembly(migrationsAssembly));
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

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, ex.Message);
}
finally
{
    Log.CloseAndFlush();
}

