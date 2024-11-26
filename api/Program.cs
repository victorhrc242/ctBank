using ctbanks.Repositors;
using ctbanks.Repositors.Interfaces;
using ctbanks.service;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
// Aprenda mais sobre configurar o Swagger/OpenAPI em https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
InicializadorBD.Inicializar();

builder.Services.AddScoped<IContapoupanca, contapoupaçarepositor>();
builder.Services.AddScoped<Icontapoupancaservice, contaservicepoupanca>();
builder.Services.AddScoped<Icontacorrente, contacorrenterepositor>();
builder.Services.AddScoped<Icontacorrentservice, contacrrentservice>();
builder.Services.AddScoped<Icontas, Contarepositor>();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
