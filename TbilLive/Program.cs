using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TbilLive.Api.Middleware;
using TbilLive.Infrastructure.Database;
using TbilLive.Infrastructure.DependencyInjection;
using TbilLive.Infrastructure.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TbilLiveDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<TbilLiveDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthorization();
builder.Services.AddControllers();

//Services Registration
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseGlobalExceptionHandler();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();