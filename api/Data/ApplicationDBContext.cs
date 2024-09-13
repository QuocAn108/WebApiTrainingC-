using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Stocks> Stocks {get; set;}
        public DbSet<Comment> Comments {get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name="User",
                    NormalizedName="USER"
                }, new IdentityRole
                {
                    Name= "Admin",
                    NormalizedName="ADMIN"
                },
            }; 
            builder.Entity<IdentityRole>().HasData(roles);
        }

    }
}
//2 cái này mục đích như nhau nhưng mà cái trên sẽ ngắn gọn hơn , sẽ được dùng trong môi trường phát triển  với setting đơn giản hơn
//cái dưới thì có thể được thiết lập nhiều setting hơn và sử dụng trong môi trường sản xuất với các yêu cầu bảo mật và cấu hình phức tạp hơn
/*  "DefaultConnection" : "Server=RYAN-HOANG\\QUOCAN;Database=Product;Trusted_Connection=True;TrustServerCertificate=True" ,
    "DefaultConnection" : "Data Source=sa\\SQLEXPRESS;Initial Catalog=WebApiTraining;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" 
 */