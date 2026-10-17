using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class TipoBicicletaDAL
    {
        public TipoBicicleta obtenerTipoBicicletaPorId(int idTipoBicicleta)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ParcialUnoConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM TIPO_BICICLETA WHERE ID_TIPO_BICICLETA = @idTipoBicicleta";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idTipoBicicleta", idTipoBicicleta);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                return TipoBicicletaMapper.Map(sqlDataReader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TipoBicicleta> obtenerTipoBicicletas()
        {
            try
            {
                List<TipoBicicleta> tipoBicicletas = new List<TipoBicicleta>();

                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ParcialUnoConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM TIPO_BICICLETA";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                tipoBicicletas.Add(TipoBicicletaMapper.Map(sqlDataReader));
                            }
                        }
                    }
                }
                return tipoBicicletas;

            }
            catch (Exception ex)
            {
                throw;
            }
        } 
    }
}
