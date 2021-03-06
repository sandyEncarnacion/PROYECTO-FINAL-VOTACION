﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ELECCIONES.LDTO
{
    public class LoginLDTO
    {

        [Required(ErrorMessage = "Favor ingresar nombre de usuario ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Ingresar contraseña ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Recordar")]
        public bool RememberME { get; set; }

    }
}
