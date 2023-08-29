using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;


namespace Ribbon.Clases
{
    
    public class Categoria
    {
        SQLCnx SQL = new SQLCnx();

        public int id { get; set; }
        public string categoria { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idUsuario { get; set; }

        public DataTable lista()
        {
            return SQL.getDataTable("SELECT idCategoria Id, Categoria FROM Categorias ORDER BY Categoria");
        }

        /// <summary>
        /// Agrega una nueva categoria a la BD
        /// </summary>
        /// <param name="categoria">Nombre de la categoría</param>
        /// <returns></returns>
        public int set(Categoria categoria)
        {
            return SQL.ejecutarQry("INSERT INTO Categorias (Categoria,idUsuario) VALUES('" + categoria.categoria + "', " + categoria.idUsuario + ")");
        }


    }
}
