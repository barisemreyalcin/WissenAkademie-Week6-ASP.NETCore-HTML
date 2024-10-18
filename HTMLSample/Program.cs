var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

/* Arayaca�� sayfalar:
* index.html
* index.htm
* default.html
* default.htm
*/

// default sayfam� ayarlamak i�in:
DefaultFilesOptions option = new DefaultFilesOptions();
option.DefaultFileNames.Clear();
option.DefaultFileNames.Add("Index8.html");
app.UseDefaultFiles(option); // app middleware oluyor
app.UseStaticFiles(); // wwwroot alt�ndaki dosyalar� kullan demek

app.Run();
