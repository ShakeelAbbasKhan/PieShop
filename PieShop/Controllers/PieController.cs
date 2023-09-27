using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPieRepository _pieRepository;
        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }
        public IActionResult List()
        {
            //ViewBag.currentCategory = "show data";
            //return View(_pieRepository.AllPies);

            PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies,"show data");
            return View(pieListViewModel);
            
        }
        public IActionResult Details(int id)
        {
           var pie = _pieRepository.GetPieById(id);
            if(pie==null)
            {
                return NotFound();
            }
            return View(pie);


        }
    }
}
