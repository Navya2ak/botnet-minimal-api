using System.ComponentModel;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=>{
c.SwaggerDoc("v1",new OpenApiInfo{Title="Pizza store API",Description="Just for a fun",Version="v1"});
});
var app = builder.Build();

if(app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI((c=>{
    c.SwaggerEndpoint("/swagger/v1/swagger.json","V1");
}));
}
app.MapGet("/", () => "Hello World!");

app.Run();
