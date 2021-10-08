using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context; // readonly previne que a depedência não seja alterada

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) // Método para inserir objeto no banco de dados
        {
            obj.Department = _context.Department.First(); // Pega o primeiro departamento que existe no banco
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
