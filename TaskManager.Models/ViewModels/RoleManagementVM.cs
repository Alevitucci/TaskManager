using System.Web.Mvc;

namespace TaskManager.Models.ViewModels
{
    public class RoleManagementVM
    { public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }
    }
}