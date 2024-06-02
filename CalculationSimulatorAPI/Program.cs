using CalculationSimulatorAPI.Infra.IoC;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging(log =>
{
    log.ClearProviders();
    log.SetMinimumLevel(LogLevel.Debug);
    log.AddConsole(options =>
    {
        options.LogToStandardErrorThreshold = LogLevel.Debug;
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddServices();
builder.Services.AddValidators();
builder.Services.AddRouting(opt=> opt.LowercaseUrls = true);
builder.Services.AddMvc().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
   app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts().UseHttpsRedirection();
}


app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

await app.RunAsync();
