using System;
using System.Text;
using SQLite;
using System.Collections.Generic;


namespace Ejercicio1_4.Models
{
  public  class Empleados
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        public String nombres { get; set; }

        public String descripcion { get; set; }

        public byte[] imagen { get; set; }
    }
}
