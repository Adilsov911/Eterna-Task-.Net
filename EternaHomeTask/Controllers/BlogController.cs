using EternaHomeTask.DAL;
using EternaHomeTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaHomeTask.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(b => b.Trainer).Include(b=>b.Search).ToList();

            return View(blogs);
        }
    }
}
