using Project_Catalog.Classes;

var builder = WebApplication.CreateBuilder(args);
//добавление зависимостей
builder.Services.AddSingleton<IMyDateTime, MyDateTimeUTC>();
builder.Services.AddSingleton<ICatalog, MyCatalog>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/catalog", (ICatalog catalog) => catalog.GetProductList());
app.Run();