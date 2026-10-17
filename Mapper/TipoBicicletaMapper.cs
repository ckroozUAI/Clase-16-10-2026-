using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TipoBicicletaMapper
    {
        public static TipoBicicleta Map(SqlDataReader sqlDataReader)
        { 
                TipoBicicleta tipoBicicleta = new TipoBicicleta();
                tipoBicicleta.IdTipoBicicleta = Convert.ToInt32(sqlDataReader["ID_TIPO_BICICLETA"])!;
                tipoBicicleta.Descripcion = Convert.ToString(sqlDataReader["DESCRIPCION"])!;

                return tipoBicicleta;
            
        }
    }
}
