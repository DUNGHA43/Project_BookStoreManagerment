
using Microsoft.EntityFrameworkCore;
using WebAPI_BookStoreManagement.Data.DBContext;
using WebAPI_BookStoreManagement.Data.UnitOfWork;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DBBookStoreContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IStaffService, StaffService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IPublisherService, PublisherService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IAuthorService, AuthorService>();
            builder.Services.AddScoped<IBookReceiptServices, BookReceiptServices>();
            builder.Services.AddScoped<IBookReceiptDetailServices, BookReceiptDetailServices>();
            builder.Services.AddScoped<IBookInvoiceService, BookInvoiceService>();
            builder.Services.AddScoped<IBookInvoiceDetailService, BookInvoiceDetailService>();


            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}
