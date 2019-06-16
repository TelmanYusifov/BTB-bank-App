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
        private static readonly DbSet<User> _users;
        public DbSet<User> Users { get { return _users; }}
        static DbContext()
        {
            _users = new DbSet<User>();
        }
    }
}
