﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    public interface IVentaService
    {
        void Create(Venta venta);
        Venta Read(long id);
        IList<Venta> ReadAll();
        void Update(Venta venta);
        void Delete(long id);
    }
}
