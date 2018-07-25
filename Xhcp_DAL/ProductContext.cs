using Microsoft.EntityFrameworkCore;
using Xhcp_Entity.Table;

namespace Xhcp_DAL
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            // 对连接数据库的字符串做加密解密操作
        }
        public DbSet<Product> Courses { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelbuilder)
        //{
        //    //base.OnModelCreating(modelbuilder);
        //    modelbuilder.Entity<Product>();
        //}
    }
}
