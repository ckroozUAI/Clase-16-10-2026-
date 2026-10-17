namespace Entity
{
    public class Alquiler
    {
		private int numeroAlquiler;
		private TipoBicicleta tipoBicicleta;
 		private string dniCliente;
		private double importeTotal;
		private DateTime fechaRegistro;
		private DateTime fechaAlquiler;

        public int NumeroAlquiler { get => numeroAlquiler; set => numeroAlquiler = value; }
 		public string DniCliente { get => dniCliente; set => dniCliente = value; }
		public double ImporteTotal { get => importeTotal; set => importeTotal = value; }
		public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
		public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public TipoBicicleta TipoBicicleta { get => tipoBicicleta; set => tipoBicicleta = value; }
    }
}
