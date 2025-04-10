using TaskManager.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManager.DataAccess;
using TaskManager.DataAccess.Data;
using TaskManager.Models.ViewModels;
using TaskManager.Models;
using TaskManager.DataAccess.Repository.IRepository;

namespace TaskManager_CORSO_UDEMY.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]

    public class UserController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        public UserController(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RoleManagement(string userId)
        {
            RoleManagementVM RoleVM = new RoleManagementVM()
            {
                ApplicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId),
            };

            RoleVM.ApplicationUser.Role = _userManager.GetRolesAsync(_unitOfWork.ApplicationUser.Get(u => u.Id == userId)).GetAwaiter().GetResult().FirstOrDefault();
            return View(RoleVM);
        }
        [HttpPost]
        public IActionResult RoleManagement(RoleManagementVM roleManagementVM)
        {
            string oldRole = _userManager.GetRolesAsync(_unitOfWork.ApplicationUser.Get(u => u.Id == roleManagementVM.ApplicationUser.Id)).GetAwaiter().GetResult().FirstOrDefault();
            ApplicationUser applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == roleManagementVM.ApplicationUser.Id);

            //if (!(roleManagementVM.ApplicationUser.Role == oldRole))
            //{
            //    if (roleManagementVM.ApplicationUser.Role == SD.Role_Company)
            //    {
            //        applicationUser.CompanyId = roleManagementVM.ApplicationUser.CompanyId;
            //    }
            //    if (oldRole == SD.Role_Company)
            //    {
            //        applicationUser.CompanyId = null;
            //    }
            //    _unitOfWork.ApplicationUser.Update(applicationUser);
            //    _unitOfWork.Save();
            //    _userManager.RemoveFromRoleAsync(applicationUser, oldRole).GetAwaiter().GetResult();
            //    _userManager.AddToRoleAsync(applicationUser, roleManagementVM.ApplicationUser.Role).GetAwaiter().GetResult();
            //}
            //else
            //{
            //    if (oldRole == SD.Role_Company && applicationUser.CompanyId != roleManagementVM.ApplicationUser.CompanyId)
            //    {
            //        applicationUser.CompanyId = roleManagementVM.ApplicationUser.CompanyId;
            //        _unitOfWork.ApplicationUser.Update(applicationUser);
            //        _unitOfWork.Save();
            //    }
            //}
            return RedirectToAction("Index");
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<ApplicationUser> objUserList = _unitOfWork.ApplicationUser.GetAll(includeProperties: "Company").ToList();

            foreach (var user in objUserList)
            {
                user.Role = _userManager.GetRolesAsync(user).GetAwaiter().GetResult().FirstOrDefault();
                
            }
            return Json(new { data = objUserList });
        }
        [HttpPost]
        public IActionResult LockUnlock([FromBody] string id)
        {
            var objFromDb = _unitOfWork.ApplicationUser.Get(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new { success = true, message = "Errore durante bloccaggio/sbloccaggio" });
            }
            if (objFromDb.LockoutEnd != null && objFromDb.LockoutEnd > DateTime.Now)
            {
                objFromDb.LockoutEnd = DateTime.Now;
            }
            else
            {
                objFromDb.LockoutEnd = DateTime.Now.AddYears(1000);
            }
            _unitOfWork.ApplicationUser.Update(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Operazione eseguita" });
        }
        #endregion
    }
}