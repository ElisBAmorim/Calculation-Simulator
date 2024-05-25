using CalculationSimulatorAPI.Infra.IoC;

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

var app = builder.Build();

// Configure the HTTP request pipeline.
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

app.UseAuthorization();

app.MapControllers();

app.Run();