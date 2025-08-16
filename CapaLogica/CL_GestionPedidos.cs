using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_GestionPedidos
    {

        //Metodo que retorna el precio desde menu Producto segun lo seleccionado//
        public double MtdPrecio(string MenuProducto)
        {
            if (MenuProducto == "1-Personal") return 100;
            if (MenuProducto == "2-Medio") return 200;
            if (MenuProducto == "3-Familiar") return 300;
            return 0;

        }

        //Metodo que retorna el precio total del pedido//
        public double MtdTotalPrecio(double Cantidad, double Precio)
        {
            return Cantidad * Precio;
        }

        // Metodo que retorna la propina 
        public double MtdPropina(string MenuProducto, double TotalPrecio)
        {
            if (MenuProducto == "1-Personal") return TotalPrecio * 0.08;
            if (MenuProducto == "2-Medio") return TotalPrecio * 0.12;
            if (MenuProducto == "3-Familiar") return TotalPrecio * 0.16;
            return 0;

        }
        
        //Metodo que retorna el precio total mas la Propina del pedido//
        public double MtdPedido(double TotalPrecio, double Propina)
        {
            return TotalPrecio * Propina;
        }

    }
}
