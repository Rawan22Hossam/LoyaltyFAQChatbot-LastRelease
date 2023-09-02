using LoyaltyFAQChatbot.Context;
using Microsoft.EntityFrameworkCore;
using LoyaltyFAQChatbot.EntityConfiguration;
using AutoMapper;
using LoyaltyFAQChatbot.GenericRepository;
using LoyaltyFAQChatbot.Services;
using System.Text;
using LoyaltyFAQChatbot.Services;

namespace LoyaltyFAQChatbot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IQuestionService, QuestionService>();
            builder.Services.AddScoped<ITransactionService, TransactionService>();
            builder.Services.AddScoped<ITicketServcie, TicketService>();
            builder.Services.AddScoped<ICouponsService, CouponsService>();
            builder.Services.AddScoped<IAnswerService, AnswerService>();
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            // Add services to the container.
            builder.Services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("LoyaltyFAQChatbot")));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
          
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            try
            {
                using (var scope = builder.Services.BuildServiceProvider().CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                    dbContext.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }
            

            app.MapControllers();

            app.Run();
        }
    }
}