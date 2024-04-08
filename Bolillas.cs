namespace Bolillero
{
    public class Bolillas
    {
        public int Numero { get; private set; }
        
        public Bolillas (string nombre, string apellido, double efectivo)
        {
            Numero = numero;
        } 

        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Efectivo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Efectivo -= monto;
        }
        public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Efectivo += monto;
        }
    }
}
















