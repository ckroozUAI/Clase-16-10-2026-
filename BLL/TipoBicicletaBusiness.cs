using DAL;
using Entity;

namespace BLL
{
    public class TipoBicicletaBusiness
    {
        private TipoBicicletaDAL TipoBicicletaDal = new();

        public List<TipoBicicleta> obtenerTipoBicicletas()
        {
            try
            {
                return TipoBicicletaDal.obtenerTipoBicicletas();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
