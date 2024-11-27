var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Urls.Add("http://localhost:5029");
app.Urls.Add("http://192.168.1.9:5029");

app.MapGet("/", () => GetHandle());

app.Run();

string GetHandle()
{
    DateTime a = DateTime.Now;
    return a.ToString();
}