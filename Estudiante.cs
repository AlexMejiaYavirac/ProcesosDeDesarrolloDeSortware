using System;
using System.Diagnostics.CodeAnalysis;

namespace informatica.negocio.test
{
    internal class Estudiante: IComparable<Estudiante>
    {
        public Estudiante()
        {
        }

        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }
        public DateTime Nacimiento { get; internal set; }

        public int CompareTo([AllowNull] Estudiante other)
        {
           return this.Nombre.CompareTo(other.Nombre);
        }
    }
}