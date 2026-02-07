var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// Returns the current UTC time
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

await app.RunAsync();
