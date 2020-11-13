using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBiciletas.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string NombreCategoria { get; set; }

        public ICollection<Bicicleta> Bicicletas { get; set; }
    }
}
