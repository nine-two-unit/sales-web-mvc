using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Data;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context; // readonly previne que a depedência não seja alterada

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() // Sufixo Async é uma recomendação de nome do C#
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
