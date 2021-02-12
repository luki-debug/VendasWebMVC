using VendasWebMVC.Data;
using System.Linq;
using VendasWebMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasWebMVC.Services
{
    public class DepartmentService
    {
        private readonly VendasWebMVCContext _context;
        public DepartmentService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
