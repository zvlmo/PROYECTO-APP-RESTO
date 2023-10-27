using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiGirolamo.Matias
{
    /// <summary>
    /// Clase que representa un restaurante de tipo fastfood.
    /// </summary>
    public class FastFood:Restaurante
    {
        private bool comboParaNinios;
        private int cantCombos;
        private string tipoRestaurante;

        public bool ComboParaNinios
        {
            get { return comboParaNinios; }
            set { comboParaNinios = value; }
        }
        public int CantCombos
        {
            get { return cantCombos; }
            set { cantCombos = value; }
        }
        public string TipoRestaurante
        {
            get { return tipoRestaurante; }
            set { tipoRestaurante = value; }
        }
        public FastFood()
        {

        }
        public FastFood(bool reserva, int capacidad, string nombre, EEstado estado) : base(reserva, capacidad, nombre, estado)
        {
            this.tipoRestaurante = "Comida Rapida";

        }
        public FastFood(bool comboParaNinios, bool reserva, int capacidad, string nombre, EEstado estado) : this(reserva, capacidad, nombre, estado)
        {
            this.comboParaNinios = comboParaNinios;
        }
        /// <summary>
        /// Constructor de la clase FastFood que permite inicializar la cantidad de combos, combo para niños, reserva, capacidad, nombre y estado del restaurante.
        /// </summary>
        /// <param name="cantCombos">La cantidad de combos habilitados en el restaurante.</param>
        /// <param name="comboParaNinios">Un valor que indica si se ofrece un combo para niños.</param>
        /// <param name="reserva">Un valor que indica si se permiten reservas.</param>
        /// <param name="capacidad">La capacidad del restaurante.</param>
        /// <param name="nombre">El nombre del restaurante.</param>
        /// <param name="estado">El estado del restaurante (Abierto o Cerrado).</param>
        public FastFood(int cantCombos, bool comboParaNinios, bool reserva, int capacidad, string nombre, EEstado estado) : this(comboParaNinios, reserva, capacidad, nombre, estado)
        {
            this.cantCombos = cantCombos;
        }
        /// <summary>
        /// Cierra el restaurante del fastfood, cambiando su estado de Abierto a Cerrado.
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
        /// Habilita o deshabilita las reservas en el restaurante de el fastfood según la capacidad.
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
            string habilitadoCombo;
            if (this.comboParaNinios == true)
            {
                habilitadoCombo = "esta habilitado";
            }
            else
            {
                habilitadoCombo = "no esta habilitado";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendLine($"- Restaurante {this.TipoRestaurante} - El menu infantil {habilitadoCombo} y tenemos {this.cantCombos} combos habilitados");

            return sb.ToString();
        }
        /// <summary>
        /// Determina si dos restaurantes de fastfood son iguales en capacidad, estado y cantidad de combos.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>true si los restaurantes son iguales, de lo contrario, false.</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is FastFood ff)
            {
                retorno = Capacidad == ff.Capacidad && Estado == ff.Estado && cantCombos == ff.cantCombos;
            }

            return retorno;
        }
        public override int GetHashCode()
        {
            return (Capacidad, Estado, cantCombos).GetHashCode();
        }
        public static bool operator ==(FastFood r1, FastFood r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(FastFood r1, FastFood r2)
        {
            return !(r1 == r2);
        }


    }
    

}


 