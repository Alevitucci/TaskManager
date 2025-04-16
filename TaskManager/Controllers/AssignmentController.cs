using TaskManager.DataAccess.Repository;
using TaskManager.DataAccess.Repository.IRepository;
using TaskManager.Models;
using TaskManager.Models.ViewModels;
using TaskManager.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.DependencyResolver;

namespace TaskManager.Controllers
{
    //[Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class AssignmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AssignmentController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Assignment> objAssignmentList = _unitOfWork.Assignment.GetAll().ToList();

            return View(objAssignmentList);
        }

        public IActionResult Upsert(int? Id) 
        {
            AssignmentVM assignmentVM = new()
            {

                Assignment = new Assignment()
            };
            if (Id == null || Id == 0)
            {
                //create
                return View(assignmentVM);
            }
            else
            {
                //update
                assignmentVM.Assignment = _unitOfWork.Assignment.Get(u => u.Id == Id);
                return View(assignmentVM);

            }
        }

        [HttpPost]
        public IActionResult Upsert(AssignmentVM assignmentVM)
        {
            if (ModelState.IsValid)
            {
                if (assignmentVM.Assignment.Id == 0)
                {
                    _unitOfWork.Assignment.Add(assignmentVM.Assignment);
                }
                else
                {
                    _unitOfWork.Assignment.Update(assignmentVM.Assignment);
                }
                _unitOfWork.Save();

                string wwwRootPath = _webHostEnvironment.WebRootPath;

                return RedirectToAction("Index");
            }
            else
            {
                //assignmentVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem

                //{
                //    Text = u.Name,
                //    Value = u.Id.ToString()

                //});
            }
                return View(assignmentVM);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Assignment> objProductList = _unitOfWork.Assignment.GetAll().ToList();
            return Json(new { data = objProductList });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var productToBeDeleted = _unitOfWork.Assignment.Get(u => u.Id == id);
            if (productToBeDeleted == null)
            {
                return Json(new { success = false, message = "Errore durante la cancellazione" });
            }

        //    string productPath = @"images\products\product-" + id;
        //    string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, productPath);

        //    if (!Directory.Exists(finalPath)) {
        //        string[] filePaths = Directory.GetFiles(finalPath);
        //        foreach (string filePath in filePaths)
        //        {
        //            System.IO.File.Delete(filePath);
        //        }
        //        Directory.CreateDirectory(finalPath);
        //}
            _unitOfWork.Assignment.Remove(productToBeDeleted);
            _unitOfWork.Save();

            List<Assignment> objProductList = _unitOfWork.Assignment.GetAll()/*(includeProperties: "Category")*/.ToList();
            return Json(new { data = objProductList });
        }
        #endregion
    }
}