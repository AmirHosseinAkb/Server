var webApplicationOptions = new WebApplicationOptions()
{
    EnvironmentName = Microsoft.Extensions.Hosting.Environments.Development
};

var builder = WebApplication.CreateBuilder(webApplicationOptions);

builder.Services.AddRazorPages();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Errors/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
