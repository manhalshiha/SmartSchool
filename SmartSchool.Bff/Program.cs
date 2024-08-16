using Refit;
using SmartSchool.Bff.ApiClients;
using SmartSchool.Bff.Students;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRefitClient<IStudentsApiClients>()
    .ConfigureHttpClient(c=>c.BaseAddress=new Uri("http://students"));

var app = builder.Build();
app.AddStudentEndpoints();
app.MapDefaultEndpoints();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

