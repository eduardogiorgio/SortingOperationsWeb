using System.ComponentModel.DataAnnotations;

namespace SortingOperationsWeb.ViewModels
{
    public class OrderStringsViewModel
    {
        [Display(Name = "Input string separated by enter")]
        [Required(ErrorMessage = "The input is required")]
        [RegularExpression(@"[a-z\n\r]*", ErrorMessage = "Invalid input. Only valid a-z and enter")]
        public string Input { get; set; } = "";
        [Display(Name = "Output")]
        public string Output { get; set; } = "";

    }
}
