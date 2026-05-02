var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // enables controllers

// ✅ Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); //enables Swaggers

var app = builder.Build();

// ✅ Enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();  //Connects controller to Map

app.Run();