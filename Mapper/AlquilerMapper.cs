using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class AlquilerMapper
    {
        public static Alquiler Map(SqlDataReader sqlDataReader,TipoBicicleta tipoBicicleta)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.NumeroAlquiler = Convert.ToInt32(sqlDataReader["NUMERO_ALQUILER"]);
            alquiler.TipoBicicleta = tipoBicicleta;
            alquiler.DniCliente = Convert.ToString(sqlDataReader["DNI_CLIENTE"])!;
            alquiler.ImporteTotal = Convert.ToDouble(sqlDataReader["IMPORTE_TOTAL"]);
            alquiler.FechaRegistro = Convert.ToDateTime(sqlDataReader["FECHA_REGISTRO"]);
            alquiler.FechaAlquiler = Convert.ToDateTime(sqlDataReader["FECHA_ALQUILER"]);

            return alquiler;
        }
    }
}
