

using System.Web.WebPages.Html;

namespace TaskManager.Models.ViewModels
{
    public class RoleManagementVM
    {
        public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; } = new List<SelectListItem>(); // Fix for CS8618
    }
}