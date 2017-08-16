using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tracker.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tracker.Controllers
{
    public class AssociateController : Controller
    {
        private IAssociateRepository associateRepo;
        // GET: /<controller>/
        public AssociateController(IAssociateRepository thisRepo = null)
        {
            if (thisRepo == null)
            {
                this.associateRepo = new EFAssociateRepository();
            }
            else
            {
                this.associateRepo = thisRepo; 
            }
        }


        public ViewResult Index()
        {
            return View(associateRepo.Associates.ToList());
        }

        public IActionResult Details(int id)
        {
            Associate thisItem = associateRepo.Associates.FirstOrDefault(x => x.Id == id);
            return View(thisItem);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Associate associate)
        {
            associateRepo.Save(associate);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Associate thisItem = associateRepo.Associates.FirstOrDefault(x => x.Id == id);
            return View(thisItem);
        }

        [HttpPost]
        public IActionResult Edit(Associate associate)
        {
            associateRepo.Edit(associate);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Associate thisItem = associateRepo.Associates.FirstOrDefault(x => x.Id == id);
            return View(thisItem);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Associate thisItem = associateRepo.Associates.FirstOrDefault(x => x.Id == id);
            associateRepo.Remove(thisItem);
            return RedirectToAction("Index");
        }
    }
}