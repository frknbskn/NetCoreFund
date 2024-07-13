var builder = WebApplication.CreateBuilder(args);//bit web uygulamas�n� aya�a kald�rabilmek i�in baz� enviroment de�erlere, baz� nesnelere, baz� konfig�rasyonlara ihtiya� duyar. ��te bunlar� CreateBuilder'�n �zerine koyup in�a ediyoruz. Def konfig�rasyonlar i�li �u an nesnede.
//Bu uygulama aya�a kalkarken hangi temel de�erlere bak�p ona g�re aya�a kald�ral�m.

builder.Services.AddControllersWithViews(); //MVC i�in

var app = builder.Build();  //buildden �nce b�t�n uygulamam�zda ihtiyac�m�z olan konfig�rasyonu bitirmemiz laz�m buradan sonra web app haz�r. buradan sonra http req ba�lar ve uygulama aya�a kalkar.

//app.MapGet("/", () => "Hello World!"); // / root ana sayfa
app.UseStaticFiles();
app.UseRouting(); //rota kullan
app.MapControllerRoute("default", "{controller=Home}/{action=Index}"); 

app.Run();
