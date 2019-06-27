using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormEjemplo1.dto
{
    // DTO es una clase de modelo para transportar informacion
    // Data Transfer Object
    // No es para ingresar manualmente
    // Value Object  VO

    public class CompraDto
    {
        public string Pais { set; get;}
        public int Cantidad { set; get;}
    }
}