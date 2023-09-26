using Reactivities.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServiceCollection(builder.Configuration);
//builder.Services.AddCors(option =>
//{
//    option.AddPolicy("CorsPolicy", policy =>
//    {
//        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3001/");
//    });
//});
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
//app.UseCors("CorsPolicy");
app.UseCors(builder =>
{
    builder
           .AllowAnyMethod()
           .AllowAnyHeader()
           .WithOrigins("http://localhost:3001");
});
app.MapControllers();

app.Run();
