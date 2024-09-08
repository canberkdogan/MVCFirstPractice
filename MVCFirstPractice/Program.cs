var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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


// Türkçe:

// Controller: Uygulamanýn iþ mantýðýný barýndýran sýnýftýr. Gelen istekleri alýr, uygun bir modeli hazýrlar ve bu modeli bir view'a gönderir.
// Action: Controller içinde yer alan ve HTTP isteklerine yanýt veren metotlardýr. Genellikle kullanýcýnýn isteðine uygun iþlemler yapar ve bir view döner.
// Model: Uygulamanýn verilerini ve bu verilerle ilgili iþ mantýðýný temsil eder. Veritabanýndan gelen veya veritabanýna gönderilen verileri içerir.
// View: Kullanýcýya gösterilecek arayüzdür. Model'den gelen verileri ekrana basar.
// Razor: ASP.NET Core'da kullanýlan bir þablon motorudur. HTML ile C# kodlarýný birleþtirmek için kullanýlýr.
// RazorView: Razor þablon motoru ile oluþturulmuþ bir view'dir. Bu view, model verilerini kullanýcýya HTML olarak gösterir.
// wwwroot: Uygulamanýn statik dosyalarýný (CSS, JavaScript, resimler gibi) barýndýran klasördür. Bu dosyalar doðrudan tarayýcýya servis edilir.
// builder.Build(): Uygulamayý yapýlandýrýr ve çalýþtýrýlmak üzere gerekli servisleri hazýrlar.
// app.Run(): Uygulamayý baþlatýr ve HTTP isteklerini dinlemeye baþlar.

// English:

// Controller: The class that contains the business logic of the application. It receives incoming requests, prepares an appropriate model, and sends this model to a view.
// Action: Methods within a controller that respond to HTTP requests. They usually perform operations based on the user's request and return a view.
// Model: Represents the data of the application and the business logic associated with this data. It contains data from or to be sent to the database.
// View: The user interface that is displayed to the user. It renders the data from the model to the screen.
// Razor: A template engine used in ASP.NET Core to combine HTML and C# code.
// RazorView: A view created with the Razor template engine. This view displays the model data to the user in HTML format.
// wwwroot: The folder that contains static files (such as CSS, JavaScript, images) of the application. These files are served directly to the browser.
// builder.Build(): Configures the application and prepares the necessary services to run it.
// app.Run(): Starts the application and begins listening for HTTP requests.
