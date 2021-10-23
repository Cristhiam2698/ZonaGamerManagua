using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZonaGamerN.Data
{
    public class Producto
    {
        [Required]
        public int Id_Producto { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La categoria es requerida.")]
       
        public int Categoria { get; set; }
        [Required(ErrorMessage = "La Marca es requerida.")]
        public int Marca { get; set; }
        [Required(ErrorMessage = "El precio de compra es requerido.")]
        public int Precio_Compra { get; set; }
        [Required(ErrorMessage = "El precio de compra es requerido.")]
        public int Precio_Venta { get; set; }

        [Required(ErrorMessage = "La descripcion es requerido.")]
        public string Descripcion { get; set; }
   

    }
}

