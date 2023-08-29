using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribbon.Clases
{
    public class SubCategoria
    {
        SQLCnx SQL = new SQLCnx();

        public int idSubCategoria { get; set; }
        public int idCategoria { get; set; }
        public string subCategoria { get; set; }     
        public DateTime fechaCreacion { get; set; }
        public int idUsuario { get; set; }

        public int agregar(SubCategoria subcategoria)
        {
            return SQL.ejecutarQry("INSERT INTO SubCategorias (idCategoria,SubCategoria,idUsuario) VALUES(" + 
                subcategoria.idCategoria + ", '" + subcategoria.subCategoria + "'," + subcategoria.idUsuario + ")");
        }
    }
}
