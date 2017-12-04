using HW_5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HW_5.DAL
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=myDBContext") { }
        public virtual DbSet<Orders> OrderSet { get; set; }
    }
}