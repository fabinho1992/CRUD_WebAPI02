using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.Json.Serialization;
using webAPI02.Infraestrutura;
using webAPI02.Repository;
using webAPI02.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling =
                                Newtonsoft.Json.ReferenceLoopHandling.Ignore);// adcionei o NewtonsoftHson para poder autualizar o banco usando o verbo PATCH

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IProdutoRepository, ProdutosRepository>();// AQUI FAÇO A INJEÇÃO DE DEPENDENCIA PARA QUE POSSA USAR O PADRÃO REPOSITORY NA CONTROLLER
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IVendedorRepository, VendedorRepository>();
builder.Services.AddTransient<IVendaRepository, VendaRepository>();
builder.Services.AddTransient<IVendaItensRepository, VendaItensRepository>();

var connectionString = builder.Configuration.GetConnectionString("ConexaoProdutos");
builder.Services.AddDbContext<DbContextControle>(op => op.UseLazyLoadingProxies().UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
