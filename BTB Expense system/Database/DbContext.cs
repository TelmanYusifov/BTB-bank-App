using BTB_Expense_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Expense_system.Database
{
    public class DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbContext()
        {
            Users = new DbSet<User>();
        }
    }
}
