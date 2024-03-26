using ConfigurationTask.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<SocialMediaLinksOptions>(builder.Configuration.GetSection("SocialMediaLinks"));
var app = builder.Build();
app.MapControllers();
app.UseStaticFiles(); 	

app.Run();
