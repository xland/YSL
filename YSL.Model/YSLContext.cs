using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;

namespace YSL.Model
{
    public class YSLContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("mysql_conn");
            optionsBuilder.UseMySql(connectionString);
        }
        #region Sys
        /// <summary>
        /// 系统权限
        /// </summary>
        public DbSet<sys_func> sys_func
        {
            get;
            set;
        }
        /// <summary>
        /// 系统账户
        /// </summary>
        public DbSet<sys_account> sys_account
        {
            get;
            set;
        }
        /// <summary>
        /// 系统角色
        /// </summary>
        public DbSet<sys_role> sys_role
        {
            get;
            set;
        }
        /// <summary>
        /// 系统角色权限关系实体
        /// </summary>
        public DbSet<sys_role_func> sys_role_func
        {
            get;
            set;
        }
        /// <summary>
        /// 系统帐号角色关系实体
        /// </summary>
        public DbSet<sys_account_role> sys_account_role
        {
            get;
            set;
        }
        #endregion
        #region Hrm
        /// <summary>
        /// 员工
        /// </summary>
        public DbSet<hrm_employee> hrm_employee
        {
            get;
            set;
        }
        /// <summary>
        /// 部门
        /// </summary>
        public DbSet<hrm_department> hrm_department
        {
            get;
            set;
        }
        ///// <summary>
        ///// 部门员工关系实体
        ///// </summary>
        public DbSet<hrm_department_employee> hrm_department_employee
        {
            get;
            set;
        }
        ///// <summary>
        ///// 员工培训
        ///// </summary>
        public DbSet<hrm_train> hrm_train
        {
            get;
            set;
        }
        ///// <summary>
        ///// 员工培训
        ///// </summary>
        public DbSet<hrm_course> hrm_course
        {
            get;
            set;
        }
        #endregion
    }


}
