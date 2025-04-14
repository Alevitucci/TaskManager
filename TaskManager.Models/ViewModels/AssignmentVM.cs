using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Web.WebPages.Html;

namespace TaskManager.Models.ViewModels
{
    public class AssignmentVM
    {
        public Assignment Assignment { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> StatusList { get; set; }
    }
}
