using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySQL.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    public class YSLContextFactory
    {
        /// <summary>
        /// 创建数据库操作类
        /// </summary>
        /// <returns></returns>
        public static YSLContext Create()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("mysql_conn");
            var optionsBuilder = new DbContextOptionsBuilder<YSLContext>();
            optionsBuilder.UseMySQL(connectionString);
            var context = new YSLContext(optionsBuilder.Options);
            return context;
        }
    }
}
