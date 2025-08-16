using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_GestionPedidos
    {
        //Instaciar con la base de datos 
        Conexion conn = new Conexion();

        //Metodo para consultar los datos de una tabla //
        public DataTable MtdConsultarTabla()
        {
            string Query = "select * from tbl_Pedidos;";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(Query,conn.MtdAbrirConexion());
            DataTable dt = new DataTable();
            SqlAdap.Fill(dt);
            return dt;
        }
        
        //Metodo para agregar un pedido//

    
    }
}
