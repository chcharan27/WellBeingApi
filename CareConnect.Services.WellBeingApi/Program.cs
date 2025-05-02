
using WellBeing.Services.MentelHealthApi.Configurations;
using WellBeing.Services.WellBeingApi.Services;
using WellBeing.Services.WellBeingApi.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace WellBeing.Services.WellBeingApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<WellBeingApiContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("SleepAnalyserApiContext") ?? throw new InvalidOperationException("Connection string 'SleepAnalyser' not found.")));


            builder.Services.AddAutoMapper(typeof(AutoMapperConfig).Assembly);

            builder.Services.AddTransient<ISleepAnalyserService, SleepAnalyserService>();

            builder.Services.AddTransient<IReminderSchedulerService, ReminderSchedulerService>();
            builder.Services.AddScoped<IReminderSchedulerDtoService, ReminderSchedulerDtoService>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
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
        }
    }
}
