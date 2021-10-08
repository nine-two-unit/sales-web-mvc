using System.Linq;
using System.Collections.Generic;
using SalesWebMvc.Models;
using SalesWebMvc.Data;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context; // readonly previne que a depedência não seja alterada

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
