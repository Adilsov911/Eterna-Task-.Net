using EternaHomeTask.DAL;
using EternaHomeTask.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaHomeTask.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Portfolio> portfolios = _context.Portfolios.ToList();

            return View(portfolios);
        }
    }
}
