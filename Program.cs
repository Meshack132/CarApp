var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // This includes support for MVC and TempData

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Commenting out HTTPS redirection as we are not using HTTPS.
app.UseStaticFiles();
app.UseRouting();

// If you need authorization, uncomment the next line
// app.UseAuthorization(); 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Car}/{action=Index}/{id?}");

app.Run();
