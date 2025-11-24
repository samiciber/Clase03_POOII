using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clase03.Models
{
    public class Cliente
    {
        [Display(Name = "Id Cliente")] public int idcliente { get; set; }
        [Display(Name = "Nombre Cliente")] public string nombrecia { get; set; }
        [Display(Name = "Direccion")] public string direccion { get; set; }
        [Display(Name = "Id Pais")] public string idpais { get; set; }
        [Display(Name = "Telefono")] public string fono { get; set; }

    }
}