using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAsync.Model.Entities
{
    internal class Venta
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public int Folio { get; set; }
        public double Total { get; set; }
        public int ClienteID { get; set; }
    }
}
