﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Koskills.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class UsuariosController : Controller
    {
        public IActionResult Usuarios()
        {
            return View();
        }
    }
}
