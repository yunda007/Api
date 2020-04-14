using System;
using System.Collections.Generic;
using System.Text;

namespace Api
{
    class Productos
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }

        public Int32? valor_producto { get; set; }
        public string codigo_producto { get; set; }

        public string url_img { get; set; }
    }
}
