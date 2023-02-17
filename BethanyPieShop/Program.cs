var builder = WebApplication.CreateBuilder(args);
// Add Service
builder.Services.AddControllersWithViews();


var app = builder.Build();
// Add midelWare 
app.UseStaticFiles();
if (app.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();
app.Run();
