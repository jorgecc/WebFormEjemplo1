namespace WebFormEjemplo1.base2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    // modelo+ anotaciones+llave primaria = entidad

    public partial class Usuario
    {
        public int UsuarioId { get; set; }

        [StringLength(50)]
        public string NombreCuenta { get; set; }

        [StringLength(50)]
        public string Clave { get; set; }

        [StringLength(50)]
        public string NombreCompleto { get; set; }
    }
}
