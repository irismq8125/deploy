using DemoDeployApi.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DemoDeployApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaController : ControllerBase
    {
        private readonly QuanLySinhVienContext _context;
        public KhoaController(QuanLySinhVienContext context)
        {
            _context = context;
        }

        [HttpGet("danh-sach")]
        public IActionResult DanhSach()
        {
            var item = _context.Khoas.ToList();
            return Ok(item);
        }
    }
}
