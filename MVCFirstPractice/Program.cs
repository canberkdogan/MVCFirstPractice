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


// T�rk�e:

// Controller: Uygulaman�n i� mant���n� bar�nd�ran s�n�ft�r. Gelen istekleri al�r, uygun bir modeli haz�rlar ve bu modeli bir view'a g�nderir.
// Action: Controller i�inde yer alan ve HTTP isteklerine yan�t veren metotlard�r. Genellikle kullan�c�n�n iste�ine uygun i�lemler yapar ve bir view d�ner.
// Model: Uygulaman�n verilerini ve bu verilerle ilgili i� mant���n� temsil eder. Veritaban�ndan gelen veya veritaban�na g�nderilen verileri i�erir.
// View: Kullan�c�ya g�sterilecek aray�zd�r. Model'den gelen verileri ekrana basar.
// Razor: ASP.NET Core'da kullan�lan bir �ablon motorudur. HTML ile C# kodlar�n� birle�tirmek i�in kullan�l�r.
// RazorView: Razor �ablon motoru ile olu�turulmu� bir view'dir. Bu view, model verilerini kullan�c�ya HTML olarak g�sterir.
// wwwroot: Uygulaman�n statik dosyalar�n� (CSS, JavaScript, resimler gibi) bar�nd�ran klas�rd�r. Bu dosyalar do�rudan taray�c�ya servis edilir.
// builder.Build(): Uygulamay� yap�land�r�r ve �al��t�r�lmak �zere gerekli servisleri haz�rlar.
// app.Run(): Uygulamay� ba�lat�r ve HTTP isteklerini dinlemeye ba�lar.

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
