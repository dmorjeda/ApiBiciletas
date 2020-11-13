using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBiciletas.Models
{
    public class Bicicleta
    {
        public int ID { get; set; }
        [StringLength(25)]
        public string Nombre { get; set; }
        [StringLength(25)]
        public string Modelo { get; set; }
        [StringLength(50)]
        public string DescripcionCorta { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Precio { get; set; }
        [StringLength(3, MinimumLength = 1)]
        [RegularExpression("XS|S|M|L|XL|XXL", ErrorMessage = "El tamaño debe ser XS, S, M, L, XL o XXL")]
        public string Tamano { get; set; }
        [StringLength(15)]
        public string Color { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
