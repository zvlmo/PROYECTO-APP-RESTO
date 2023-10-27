using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiGirolamo.Matias
{
    /// <summary>
    /// Clase que representa una cadena de restaurantes que gestiona una lista de restaurantes.
    /// </summary>
    public class CadenaRestaurantes
    {
        private List<Restaurante> localesRestaurantes;

        public CadenaRestaurantes()
        {
            this.localesRestaurantes = new List<Restaurante>();
        }
        /// <summary>
        /// Obtiene o establece la lista de restaurantes pertenecientes a la cadena de restaurantes.
        /// </summary>
        /// 
        public List<Restaurante> LocalesRestaurantes
        {
            get { return localesRestaurantes; }
            set {localesRestaurantes = value; }
        }



        /// <summary>
        /// Sobrecarga del operador de igualdad que compara si un restaurante está contenido en la cadena de restaurantes.
        /// </summary>
        /// <param name="restaurantes">La cadena de restaurantes.</param>
        /// <param name="local">El restaurante a comparar.</param>
        /// <returns>true si el restaurante está contenido en la cadena, de lo contrario, false.</returns>
        public static bool operator == (CadenaRestaurantes restaurantes, Restaurante local)
        {
            return restaurantes.localesRestaurantes.Contains(local);
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad que compara si un restaurante no está contenido en la cadena de restaurantes.
        /// </summary>
        /// <param name="restaurantes">La cadena de restaurantes.</param>
        /// <param name="local">El restaurante a comparar.</param>
        /// <returns>true si el restaurante no está contenido en la cadena, de lo contrario, false.</returns>
        public static bool operator !=(CadenaRestaurantes restaurantes, Restaurante local)
        {
            return !(restaurantes == local);
        }

        /// <summary>
        /// Sobrecarga del operador de adición que agrega un restaurante a la cadena de restaurantes si no está contenido en ella.
        /// </summary>
        /// <param name="restaurantes">La cadena de restaurantes a la que se agrega el restaurante.</param>
        /// <param name="local">El restaurante que se agrega a la cadena.</param>
        /// <returns>La cadena de restaurantes actualizada con el nuevo restaurante si no estaba contenido previamente.</returns>
        public static CadenaRestaurantes operator +(CadenaRestaurantes restaurantes, Restaurante local)
        {
            if (restaurantes != local)
            {
                restaurantes.localesRestaurantes.Add(local);
            }
            return restaurantes;
        }

        /// <summary>
        /// Sobrecarga del operador de sustracción que elimina un restaurante de la cadena de restaurantes si está contenido en ella.
        /// </summary>
        /// <param name="restaurantes">La cadena de restaurantes de la que se elimina el restaurante.</param>
        /// <param name="local">El restaurante que se elimina de la cadena.</param>
        /// <returns>La cadena de restaurantes actualizada sin el restaurante si estaba contenido previamente.</returns>
        public static CadenaRestaurantes operator -(CadenaRestaurantes restaurantes, Restaurante local)
        {
            if (restaurantes == local)
            {
                restaurantes.localesRestaurantes.Remove(local);
            }
            return restaurantes;
        }

        /// <summary>
        /// Compara dos restaurantes por su capacidad de manera ascendente.
        /// </summary>
        /// <param name="r1">El primer restaurante a comparar.</param>
        /// <param name="r2">El segundo restaurante a comparar.</param>
        /// <returns>Un valor negativo si r1 tiene menor capacidad que r2, un valor positivo si r1 tiene mayor capacidad que r2, o 0 si tienen igual capacidad.</returns>

        public static int OrdenarRestaurantesPorCapacidadAscendente(Restaurante r1, Restaurante r2)
        {
            int resultado = r1.Capacidad - r2.Capacidad ;
            if (resultado < 0)
            {
                return -1;
            }
            else if (resultado > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Compara dos restaurantes por su capacidad de manera descendente.
        /// </summary>
        /// <param name="r1">El primer restaurante a comparar.</param>
        /// <param name="r2">El segundo restaurante a comparar.</param>
        /// <returns>Un valor negativo si r1 tiene mayor capacidad que r2, un valor positivo si r1 tiene menor capacidad que r2, o 0 si tienen igual capacidad.</returns>
        public static int OrdenarRestaurantesPorCapacidadDescendente(Restaurante r1, Restaurante r2)
        {
            if(OrdenarRestaurantesPorCapacidadAscendente(r1, r2) == 1)
            {
                return -1;
            }
            else if (OrdenarRestaurantesPorCapacidadAscendente(r1,r2) == -1)
            {
                return 1;
            }

            else { return 0; }
        }

        /// <summary>
        /// Compara dos restaurantes alfabéticamente por nombre de manera ascendente.
        /// </summary>
        /// <param name="r1">El primer restaurante a comparar.</param>
        /// <param name="r2">El segundo restaurante a comparar.</param>
        /// <returns>Un valor negativo si el nombre de r1 es menor alfabéticamente que el de r2, un valor positivo si el
        /// nombre de r1 es mayor alfabéticamente que el de r2, o 0 si tienen igual nombre.</returns>
        public static int OrdenarRestaurantesAlfabeticamenteAscendente(Restaurante r1, Restaurante r2)
        {
            return string.Compare(r1.Nombre, r2.Nombre);
        }

        /// <summary>
        /// Compara dos restaurantes alfabéticamente por nombre de manera descendente.
        /// </summary>
        /// <param name="r1">El primer restaurante a comparar.</param>
        /// <param name="r2">El segundo restaurante a comparar.</param>
        /// <returns>Un valor negativo si el nombre de r1 es mayor alfabéticamente que el de r2, 
        /// un valor positivo si el nombre de r1 es menor alfabéticamente que el de r2, o 0 si tienen igual nombre.</returns>
        public static int OrdenarRestaurantesAlfabeticamenteDescendente(Restaurante r1, Restaurante r2)
        {
            if (OrdenarRestaurantesAlfabeticamenteAscendente(r1, r2) ==  1) { 
            
                return -1;
            }else if (OrdenarRestaurantesAlfabeticamenteAscendente(r1,r2) == -1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



    }
}
