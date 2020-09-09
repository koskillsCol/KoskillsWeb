using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Koskills.Areas.Usuarios.Pages.Account
{
    public class RegistrarModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public InputModel1 Input { get; set; }
        public class InputModel1
        {
            [Required]
            [RegularExpression(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$", ErrorMessage = "Please enter a valid name")]
            [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos de {2}.", MinimumLength = 3)]
            [Display(Name = "First Name")]
            public string PrimerNombre { get; set; }

            [RegularExpression(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$", ErrorMessage = "Please enter a valid name")]
            [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos de {2}.", MinimumLength = 3)]
            [Display(Name = "Second Name")]
            public string SegundoNombre { get; set; }

            [Required]
            [RegularExpression(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$", ErrorMessage = "Please enter a valid name")]
            [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos de {2}.", MinimumLength = 3)]
            [Display(Name = "Surname")]
            public string PrimerApellido { get; set; }

            [Required]
            [RegularExpression(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$", ErrorMessage = "Please enter a valid name")]
            [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos de {2}.", MinimumLength = 3)]
            [Display(Name = "Second Surname")]
            public string SegundoApellido { get; set; }

            [Required]
            [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "Invalid Phone Number!")]
            [StringLength(10, ErrorMessage = "The minimum phone number is 10 .", MinimumLength = 10)]
            [Display(Name = "Phone Number")]
            public string Telefono { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos de {2}.", MinimumLength = 6)]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "The Password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }
        public IActionResult OnPost(){

            if (ModelState.IsValid) { 
            
            }
            var data = Input;
            return Page();
        }
    }
}
