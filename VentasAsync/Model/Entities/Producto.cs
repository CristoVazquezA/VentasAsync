﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAsync.Model.Entities
{
    internal class Producto
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public double ValorUnitario { get; set; }
    }
}
