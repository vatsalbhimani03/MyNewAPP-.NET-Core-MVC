﻿using Microsoft.EntityFrameworkCore;
using MyNewApp.Models;

namespace MyNewApp.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }   

        public DbSet<Items> Items { get; set; }  


    }
}
