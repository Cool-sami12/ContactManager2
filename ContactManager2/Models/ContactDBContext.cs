﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager2.Models
{
    public class ContactDBContext:DbContext
    {
        public ContactDBContext(DbContextOptions<ContactDBContext> options) : base(options)
        {

        }
        public DbSet<ContactDetails> ContactDetails { get; set; }
    }
}
