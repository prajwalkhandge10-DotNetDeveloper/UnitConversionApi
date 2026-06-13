using UnitConversionApi.Converters;
using UnitConversionApi.Middleware;
using UnitConversionApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IConversionService, ConversionService>();

builder.Services.AddSingleton<IUnitConverter, LengthConverter>();
builder.Services.AddSingleton<IUnitConverter, WeightConverter>();
builder.Services.AddSingleton<IUnitConverter, TemperatureConverter>();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();