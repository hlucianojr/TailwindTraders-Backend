using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Tailwind.Traders.Profile.Api2.Extensions;
using Tailwind.Traders.Profile.Api2.Infrastructure;
using Tailwind.Traders.Profile.Api2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks(builder.Configuration);
builder.Services.AddProfileContext(builder.Configuration);
builder.Services.AddModulesProfile();
builder.Services.AddAuthentication("BasicAuthentication")
              .AddScheme<BasicAuthenticationOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ApiVersionReader = new QueryStringApiVersionReader();
});

var appInsightsIK = builder.Configuration["ApplicationInsights:InstrumentationKey"];

if (!string.IsNullOrEmpty(appInsightsIK))
{
    builder.Services.AddApplicationInsightsTelemetry(appInsightsIK);
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
});

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

