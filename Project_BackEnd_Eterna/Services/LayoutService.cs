using Microsoft.EntityFrameworkCore;
using Project_BackEnd_Eterna.DAL;
using Project_BackEnd_Eterna.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project_BackEnd_Eterna.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contact>> GetDatas()
        {
            List<Contact> contacts = await _context.Contacts.ToListAsync();
            return contacts;
        }
    }
}
