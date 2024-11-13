using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestCRM.Models;

namespace TestCRM.Data
{
    public class TestCRMContext : DbContext
    {
        public TestCRMContext (DbContextOptions<TestCRMContext> options)
            : base(options)
        {
        }

        public DbSet<TestCRM.Models.UserModel> UserModel { get; set; } = default!;
    }
}
