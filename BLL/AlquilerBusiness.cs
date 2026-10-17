using DAL;
using Entity;

namespace BLL
{
    public class AlquilerBusiness
    {
        private AlquilerDAL AlquilerDal = new();

        public void agregarAlquiler(Alquiler alquiler)
        {
            try
            {
                ValidarDNI(alquiler);
                ValidarFecha(alquiler.FechaAlquiler);
                ValidarTipoBicicleta(alquiler);
                ValidarImporte(alquiler.ImporteTotal);

                AlquilerDal.agregarAlquiler(alquiler);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarAlquiler(int idAlquiler)
        {
            try
            {


                ValidarIdAlquiler(idAlquiler);
                ValidarExisteAlquiler(idAlquiler);

                AlquilerDal.eliminarAlquiler(idAlquiler);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void modificarAlquiler(int idAlquiler, double nuevoImporte, DateTime nuevaFechaAlquiler)
        {
            try
            {
                ValidarIdAlquiler(idAlquiler);
                ValidarExisteAlquiler(idAlquiler);
                ValidarImporte(nuevoImporte);
                ValidarFecha(nuevaFechaAlquiler);


                AlquilerDal.modificarAlquiler(idAlquiler, nuevoImporte, nuevaFechaAlquiler);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Alquiler obtenerAlquilerPorId(int idAlquiler)
        {
            try
            {
                return AlquilerDal.obtenerAlquilerPorId(idAlquiler);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Alquiler> obtenerAlquileres()
        {
            try
            {
                return AlquilerDal.obtenerAlquileres();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // validaciones de aca para abajo

        public void ValidarDNI(Alquiler alquiler)
        {
            string dni = (alquiler.DniCliente ?? string.Empty).Trim();

            if (String.IsNullOrEmpty(dni))
            {
                throw new Exception("El numero de DNI no puede estar vacio.");
            }

            if (dni.Length < 5)
            {
                throw new Exception("El DNI debe tener mas de 5 caracteres.");
            }
        }

        public void ValidarFecha(DateTime fecha)
        {
            if (fecha.CompareTo(DateTime.Now) < 0)
            {
                throw new Exception("La fecha no puede ser menor a ala ctual.");
            }
        }

        public void ValidarTipoBicicleta(Alquiler alquiler)
        {
            if (alquiler.TipoBicicleta.IdTipoBicicleta == 0)
            {
                throw new Exception("Debe haber un tipo de bicicleta seleccionado");

            }
        }

        public void ValidarImporte(double importe)
        {
            if (importe <= 0)
            {
                throw new Exception("El importe debe ser mayor a 0");

            }
        }

        public void ValidarIdAlquiler(int id)
        {
            if (id <= 0)
            {
                throw new Exception("El id debe ser un entero mayor a 0");
            }
        }

        public void ValidarExisteAlquiler(int idAlquiler)
        {
            Alquiler alqtemp = obtenerAlquilerPorId(idAlquiler);
            if (alqtemp == null)
            {
                throw new Exception("No hay un alquiler con ese ID");
            }
        }
    }
}
