using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Web.WebPages.Html;

namespace TaskManager.Models.ViewModels
{
    public class TaskVM
    {
        public Task Task { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> StatusList { get; set; }
    }
}
