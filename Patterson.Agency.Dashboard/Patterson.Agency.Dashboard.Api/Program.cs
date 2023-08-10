using Microsoft.EntityFrameworkCore;
using Patterson.Agency.Dashboard.Application;
using Patterson.Agency.Dashboard.Persistence.Data;

var builder = WebApplication.CreateBuilder(args);

AddServices();

var app = builder.Build();
Configure();

app.Run();


void AddServices()
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
            sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,           
                    maxRetryDelay: TimeSpan.FromSeconds(30), 
                    errorNumbersToAdd: null     
                );
            })
    );
    
    AddDependencies();
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAllOrigins",
            corsPolicyBuilder =>
            {
                corsPolicyBuilder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
    });
}

void Configure()
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseCors("AllowAllOrigins");
    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
    app.UseHttpsRedirection();
    app.MapControllers();
    
}

void AddDependencies()
{
    builder.Services.AddApplicationLayer();
}