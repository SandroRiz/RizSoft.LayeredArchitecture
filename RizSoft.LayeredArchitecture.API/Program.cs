var builder = WebApplication.CreateBuilder(args);

const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder
                          // .WithOrigins("https://localhost:xxxx",
                          //              "https://mydomain.it")
                          // .WithMethods( "GET, POST")
                          // .WithHeaders("...")
                           .AllowAnyMethod()
                           .AllowAnyOrigin()
                           .AllowAnyHeader();
                          ;
                      });
});

var connectionString = builder.Configuration.GetConnectionString("Db");
builder.Services.AddDbContextFactory<NorthwindDbContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.MapGet("/employees", async ( IEmployeeService svc) =>
    await svc.ListAsyncWithoutPhoto());

app.Run();

