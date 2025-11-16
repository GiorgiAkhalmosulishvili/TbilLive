using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TbilLive.Infrastructure.Database;
using TbilLive.Infrastructure.DependencyInjection;
using TbilLive.Infrastructure.Identity;
using TbilLive.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TbilLiveDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<TbilLiveDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddSharedMediatR();


builder.Services.AddAuthorization();
builder.Services.AddControllers();

builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();