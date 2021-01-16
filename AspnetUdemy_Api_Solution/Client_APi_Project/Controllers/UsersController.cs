using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client_APi_Project.Data;
using Client_APi_Project.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Client_APi_Project.Controllers
{
    //[Route("api/[controller]/[action]")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<AppUser>> GetUsers()
        {
            var users = await _context.AppUsers.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var users =await  _context.AppUsers.FindAsync(id);
            return users;
        }
    }
}
