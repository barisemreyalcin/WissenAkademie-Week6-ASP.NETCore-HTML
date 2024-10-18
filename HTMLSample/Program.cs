var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

/* Arayacaðý sayfalar:
* index.html
* index.htm
* default.html
* default.htm
*/

// default sayfamý ayarlamak için:
DefaultFilesOptions option = new DefaultFilesOptions();
option.DefaultFileNames.Clear();
option.DefaultFileNames.Add("Index8.html");
app.UseDefaultFiles(option); // app middleware oluyor
app.UseStaticFiles(); // wwwroot altýndaki dosyalarý kullan demek

app.Run();
