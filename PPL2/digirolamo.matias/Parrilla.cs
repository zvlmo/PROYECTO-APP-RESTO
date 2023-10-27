using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiGirolamo.Matias
{
    /// <summary>
    /// Clase que representa un restaurante de tipo parrilla.
    /// </summary>
    public class Parrilla:Restaurante
    {
        private bool menuVegano;
        private int cantGuarniciones;
        private string tipoRestaurante;

        public bool MenuVegano
        {
            get { return menuVegano; }
            set { menuVegano = value; }
        }
        public int CantGuarniciones
        {
            get { return cantGuarniciones; }
            set { cantGuarniciones = value; }
        }
        public string TipoRestaurante
        {
            get { return tipoRestaurante; }
            set { tipoRestaurante = value; }
        }
        public Parrilla()
        {

        }
        public Parrilla(bool reserva, int capacidad, string nombre, EEstado estado) : base(reserva, capacidad, nombre, estado)
        {
            this.tipoRestaurante = "PARRILLA";
        }
        public Parrilla(bool menuVegano, bool reserva, int capacidad, string nombre, EEstado estado) : this(reserva, capacidad, nombre, estado)
        {
            this.menuVegano = menuVegano;
        }
        /// <summary>
        /// Constructor de la clase Parrilla que permite inicializar la cantidad de guarniciones, menú vegano, reserva, capacidad, nombre y estado del restaurante.
        /// </summary>
        /// <param name="cantGuarniciones">La cantidad de guarniciones habilitadas en el restaurante.</param>
        /// <param name="menuVegano">Un valor que indica si se ofrece menú vegano.</param>
        /// <param name="reserva">Un valor que indica si se permiten reservas.</param>
        /// <param name="capacidad">La capacidad del restaurante.</param>
        /// <param name="nombre">El nombre del restaurante.</param>
        /// <param name="estado">El estado del restaurante (Abierto o Cerrado).</param>
        public Parrilla(int cantGuarniciones, bool menuVegano, bool reserva, int capacidad, string nombre, EEstado estado) : this(menuVegano, reserva, capacidad, nombre, estado)
        {
            this.cantGuarniciones = cantGuarniciones;
        }
        /// <summary>
        /// Cierra el restaurante de parrilla, cambiando su estado de Abierto a Cerrado.
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
        /// Habilita o deshabilita las reservas en el restaurante de parrilla según la capacidad.
        /// Si la capacidad es mayor o igual a 50, se habilitan las reservas; de lo contrario, se deshabilitan.
        /// </summary>
        public override void HabilitarReservas()
        {
            if (base.Capacidad >= 50)
            {
                base.Reserva = true;
            }
            else base.Reserva = false;
        }
        public override string ToString()
        {
            string habilitadoMenu;
            if (this.menuVegano == true)
            {
                habilitadoMenu = "esta habilitado";
            }
            else
            {
                habilitadoMenu = "no esta habilitado";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendLine($"- Restaurante {this.TipoRestaurante}  - el menu vegano {habilitadoMenu} y tenemos {this.cantGuarniciones} guarniciones habilitadas");

            return sb.ToString();
        }
        /// <summary>
        /// Determina si dos restaurantes de parrilla son iguales en capacidad, estado y menú vegano.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>true si los restaurantes son iguales, de lo contrario, false.</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Parrilla parrilla)
            {
                retorno = Capacidad == parrilla.Capacidad && Estado == parrilla.Estado && menuVegano == parrilla.menuVegano;
            }

            return retorno;
        }
        public override int GetHashCode()
        {
            return (Capacidad, Estado, menuVegano).GetHashCode();
        }
        public static bool operator ==(Parrilla r1, Parrilla r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(Parrilla r1, Parrilla r2)
        {
            return !(r1 == r2);
        }

    }
}
