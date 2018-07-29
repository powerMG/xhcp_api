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
        /// <summary>
        /// test model
        /// </summary>
        public DbSet<Product> Courses { get; set; }
        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<UserInfo> Userinfo { get; set; }
        /// <summary>
        /// 食物分类表
        /// </summary>
        public DbSet<FoodCategory> FoodCategory { get; set; }
        /// <summary>
        /// 食物信息表
        /// </summary>
        public DbSet<FoodInfo> FoodInfo { get; set; }
        /// <summary>
        /// 食物用料表
        /// </summary>
        public DbSet<FoodIngredient> FoodIngredient { get; set; }
        public DbSet<FoodPractice> FoodPractice { get; set; }
    }
}
