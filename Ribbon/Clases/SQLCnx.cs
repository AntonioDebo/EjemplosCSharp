using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Ribbon.Clases
{
    public class SQLCnx
    {
        String connectionString = "Data Source=DEVELOP\\SQLEXPRESS;Initial Catalog=Inventario;User ID=sa;Password=Mariguana_1";
        public  void Conectar ()
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Conecion Establecida");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción:" + ex.Message);
            }
        }

        public DataTable getDataTable(string Qry)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(Qry,connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DT.Load(reader);
                        }
                    }

                }
                return DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción:" + ex.Message);
                return DT;
            }
        }

        public int ejecutarQry(string Qry)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    connection.Open();
                    string consulta = Qry + "; SELECT CAST(scope_identity() AS int)";
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        return (int)command.ExecuteScalar();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción:" + ex.Message);
                return 0;
            }
        }
    }
}
