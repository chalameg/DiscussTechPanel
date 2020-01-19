using DiscussTechPanel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace DiscussTechPanel.Data
{
    public class HRDbContext : DbContext
    {
        public HRDbContext(DbContextOptions<HRDbContext> options)
        : base(options)
        {
        }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
       
    }
}
