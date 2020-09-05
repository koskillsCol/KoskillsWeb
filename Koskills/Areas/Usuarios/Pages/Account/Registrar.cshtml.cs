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
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos de {2}.", MinimumLength = 6)]
            public string Password { get; set; }
        }
    }
}
