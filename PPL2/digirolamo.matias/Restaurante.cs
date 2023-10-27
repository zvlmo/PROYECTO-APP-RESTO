namespace DiGirolamo.Matias
{
 /// <summary>
/// Clase abstracta que representa un restaurante.
/// </summary>
    public abstract class Restaurante
    {
        private bool reserva;
        public bool Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }
        private int capacidad;
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private EEstado estado;
        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Restaurante()
        {
            this.reserva = true;
            this.capacidad = 0;
            this.nombre = "";
            this.estado = EEstado.Abierto;
        }
        public Restaurante(int capacidad,string nombre,bool reserva):this()
        {
            this.capacidad=capacidad;
            this.nombre = nombre;
            this.reserva=reserva;
        }
        /// <summary>
        /// Constructor de la clase Restaurante que permite inicializar reserva, capacidad, nombre y estado.
        /// </summary>
        /// <param name="reserva">Un valor que indica si se permiten reservas.</param>
        /// <param name="capacidad">La capacidad del restaurante.</param>
        /// <param name="nombre">El nombre del restaurante.</param>
        /// <param name="estado">El estado del restaurante (Abierto o Cerrado).</param>
        public Restaurante(bool reserva, int capacidad, string nombre, EEstado estado):this(capacidad,nombre,reserva)
        {
            this.reserva = reserva;
            this.estado = estado;
            
        }
        /// <summary>
        /// Cierra el restaurante, cambiando su estado de Abierto a Cerrado.
        /// </summary>
        /// <returns>El estado actual del restaurante después del cierre.</returns>
        public virtual EEstado CerrarRestaurante()
        {
            if (this.estado == EEstado.Abierto)
            {
                return EEstado.Cerrado;
            }
            else return EEstado.Cerrado;
        }
        /// <summary>
        /// Método abstracto que debe ser implementado en clases derivadas para habilitar las reservas en el restaurante.
        /// </summary>
        public abstract void HabilitarReservas();

        /// <summary>
        /// Obtiene una cadena que describe la capacidad del restaurante.
        /// </summary>
        /// <returns>Una cadena que describe la capacidad del restaurante.</returns>
        public string MostrarCapacidad()
        {
            return ($"El restaurante {this.nombre} tiene una capacidad de {this.capacidad}");
        }

        /// <summary>
        /// Obtiene una cadena que describe la capacidad del restaurante en comparación con otro restaurante.
        /// </summary>
        /// <param name="r">El restaurante con el que se compara la capacidad.</param>
        /// <returns>Una cadena que describe la capacidad del restaurante en relación con otro.</returns>
        public string MostrarCapacidad(Restaurante r)
        {
            if (this.capacidad > r.capacidad)
            {
                return this.MostrarCapacidad() + ", superior a " + r.nombre ;
            }
            else
            {
                return this.MostrarCapacidad() + ", menor a "+ r.nombre +" que tiene una capacidad de " + r.capacidad;
            }
        }

        /// <summary>
        /// Obtiene una representación en formato de cadena de la instancia de Restaurante.
        /// </summary>
        /// <returns>Una cadena que representa el restaurante, incluyendo nombre, capacidad y estado de reserva.</returns>

        public override string ToString()
        {
            string habilitadaReserva;
            if (this.reserva == true)
            {
                habilitadaReserva = "esta habilitada";
            } 
            else
            {
                habilitadaReserva = "no esta habilitada";
            }
            return $"{this.nombre} - Capacidad: {this.capacidad} - Reserva: {habilitadaReserva} ";
        }





    }
}