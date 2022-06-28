using BLL;
using DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddDAL(builder.Configuration.GetConnectionString("Database"))
    .AddBLL()
    .AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();