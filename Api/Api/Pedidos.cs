using System;
using System.Collections.Generic;
using System.Text;

namespace Api
{
    class Pedidos
    {
        public int id_pedido { get; set; }
        public int id_usuario { get; set; }
        public string nombre_producto { get; set; }
        public string url_imagen { get; set; }
        public int cantidad { get; set; }
        public string valor_unitario { get; set; }
        public string valor_total { get; set; }
    
    }
}
