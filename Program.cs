using atmservice.Application.Extention;


var builder = WebApplication.CreateBuilder(args);
builder.Services.InjectServices();
var app = builder.Build();

app.InjectEnvoirmentExtention(app.Environment);

// app.UseHttpsRedirection();
// app.UseAuthorization();
app.MapControllers();
app.Run();

