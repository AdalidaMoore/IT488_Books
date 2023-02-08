﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class AppContextDB : DbContext
    {
        public AppContextDB(DbContextOptions<AppContextDB> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}