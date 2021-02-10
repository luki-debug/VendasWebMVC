using VendasWebMVC.Data;
using System.Linq;
using VendasWebMVC.Models;
using System.Collections.Generic;

namespace VendasWebMVC.Services
{
    public class DepartmentService
    {
        private readonly VendasWebMVCContext _context;
        public DepartmentService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
