using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class SFactura
    {
        private EntidadBase entidadBase = new EntidadBase();

        internal decimal getNextNumber()
        {

            string query = string.Format("select hotel.getNextNumeroFactura()");

            decimal resultado = (decimal) entidadBase.EjecutarFuncionEscalarSQL(query);

            return resultado;
        }

        internal List<ItemFactura> getItemsFactura(string codigoReserva)
        {
            DataTable TableFunc = entidadBase.TraerDatos("hotel.sp_getItemsFactura " + codigoReserva);
            List<ItemFactura> items = new List<ItemFactura>();

            foreach (DataRow i in TableFunc.Rows)
            {
                ItemFactura item = new ItemFactura();
                item.codigo = i.Field<decimal>("codigo");
                item.descripcion = i.Field<string>("descripcion");
                item.monto = i.Field<decimal>("precio");
                items.Add(item);
            }
            return items;
        }
    }
}
