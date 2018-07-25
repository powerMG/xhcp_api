using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xhcp_DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProductContext>();
            builder.UseMySql("UserID = root; Password = xmwang1.q; Host = 47.104.139.46; Port=3306; Database = xhcp_Db");
            return new ProductContext(builder.Options);
        }
    }
}
