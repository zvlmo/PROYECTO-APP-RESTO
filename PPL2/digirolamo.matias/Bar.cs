using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiGirolamo.Matias
{
    public class Bar:Restaurante
    {
        private bool happyHour;
        private int cantTragos;
        private string tipoRestaurante;


        public bool HappyHour
        {
            get { return happyHour; }
            set { happyHour = value; }
        }
        public int CantTragos
        {
            get { return cantTragos; }
            set { cantTragos = value; }
        }
        public string TipoRestaurante
        {
            get { return tipoRestaurante; }
            set { tipoRestaurante = value; }
        }
        public Bar()
        {

        }

        public Bar(bool reserva, int capacidad, string nombre, EEstado estado) : base(reserva, capacidad, nombre, estado)
        {
            this.tipoRestaurante = "BAR";

        }
        public Bar(bool goldenHour,bool reserva, int capacidad, string nombre, EEstado estado) :this(reserva, capacidad, nombre, estado)
        {
            this.happyHour = goldenHour;
        }
        /// <summary>
        /// Constructor de la clase FastFood que permite inicializar la cantidad de combos, combo para niños, reserva, capacidad, nombre y estado del restaurante.
        /// </summary>
        /// <param name="cantTragos">La cantidad de combos habilitados en el restaurante.</param>
        /// <param name="happyhour">Un valor que indica si se ofrece el happy hour.</param>
        /// <param name="reserva">Un valor que indica si se permiten reservas.</param>
        /// <param name="capacidad">La capacidad del restaurante.</param>
        /// <param name="nombre">El nombre del restaurante.</param>
        /// <param name="estado">El estado del restaurante (Abierto o Cerrado).</param>
        public Bar(int cantTragos, bool goldenHour, bool reserva, int capacidad, string nombre, EEstado estado) : this(goldenHour,reserva, capacidad, nombre, estado)
        {
            this.cantTragos = cantTragos;
        }
        /// <summary>
        /// Cierra el restaurante del bar, cambiando su estado de Abierto a Cerrado.
        /// </summary>
        /// <returns>El estado actual del restaurante después del cierre.</returns>
        public override EEstado CerrarRestaurante()
        {
            if (this.Estado == EEstado.Abierto)
            {
                return EEstado.Cerrado;
            }
            else return EEstado.Cerrado;
        }
        /// <summary>
        /// Habilita o deshabilita las reservas en el bar según la capacidad.
        /// Si la capacidad es mayor o igual a 50, se habilitan las reservas; de lo contrario, se deshabilitan.
        /// </summary>

        public override void HabilitarReservas()
        {
            if (this.Capacidad >= 50)
            {
                 this.Reserva = true;
            }
            else  this.Reserva = false;
        }
        public override string ToString()
        {
            string habilitadaGolden;
            if (this.happyHour == true)
            {
                habilitadaGolden = "esta habilitada";
            }
            else
            {
                habilitadaGolden = "no esta habilitada";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            
            sb.AppendLine($"- Restaurante {this.TipoRestaurante} - La Happy Hour {habilitadaGolden} y tenemos {this.cantTragos} tragos habilitados");
            
            return sb.ToString();
        }
        /// <summary>
        /// Determina si dos restaurantes de fastfood son iguales en capacidad, estado y si hay happyhour.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>true si los restaurantes son iguales, de lo contrario, false.</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Bar bar)
            {
                retorno = Capacidad == bar.Capacidad && Estado == bar.Estado && happyHour == bar.happyHour;
            }

            return retorno;
        }
        public override int GetHashCode()
        {
            return (Capacidad, Estado, happyHour).GetHashCode();
        }
        public static bool operator ==(Bar r1, Bar r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(Bar r1, Bar r2)
        {
            return !(r1 == r2);
        }
    }
}
