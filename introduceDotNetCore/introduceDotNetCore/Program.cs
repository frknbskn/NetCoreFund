var builder = WebApplication.CreateBuilder(args);//bit web uygulamasýný ayaða kaldýrabilmek için bazý enviroment deðerlere, bazý nesnelere, bazý konfigürasyonlara ihtiyaç duyar. Ýþte bunlarý CreateBuilder'ýn üzerine koyup inþa ediyoruz. Def konfigürasyonlar iþli þu an nesnede.
//Bu uygulama ayaða kalkarken hangi temel deðerlere bakýp ona göre ayaða kaldýralým.

builder.Services.AddControllersWithViews(); //MVC için

var app = builder.Build();  //buildden önce bütün uygulamamýzda ihtiyacýmýz olan konfigürasyonu bitirmemiz lazým buradan sonra web app hazýr. buradan sonra http req baþlar ve uygulama ayaða kalkar.

//app.MapGet("/", () => "Hello World!"); // / root ana sayfa
app.UseStaticFiles();
app.UseRouting(); //rota kullan
app.MapControllerRoute("default", "{controller=Home}/{action=Index}"); 

app.Run();
