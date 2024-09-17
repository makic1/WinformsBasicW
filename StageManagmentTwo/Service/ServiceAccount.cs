using Microsoft.EntityFrameworkCore;
using StageManagmentTwo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagmentTwo.Service
{
    public class ServiceAccount
    {
        private readonly DbContextStageManagmentTwo _context;

        public ServiceAccount(DbContextStageManagmentTwo context)
        {
            _context = context;
        }

        public Account FindAccount(string username)
        {
            return _context.Accounts.AsNoTracking().FirstOrDefault(u => u.Username == username);
        }
    }
}
