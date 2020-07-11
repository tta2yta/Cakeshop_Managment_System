using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineCakeShop.Model;
using OnlineCakeShop.Model.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineCakeShop.Controllers
{
    public class PieController : Controller
    {
        // GET: /<controller>/

        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
      /*  public IActionResult Index()
        {
            return View();
        }*/

        public ViewResult List()
        {
            PieListViewModel _pieListViewModel = new PieListViewModel();
            _pieListViewModel.Pies = _pieRepository.AllPies;
            _pieListViewModel.CurrentCategory = "Cheese Cakes";
            //ViewBag.CurrentTite = "Cheese Cakes";
            //return View(_pieRepository.AllPies);
            return View(_pieListViewModel);

        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}
