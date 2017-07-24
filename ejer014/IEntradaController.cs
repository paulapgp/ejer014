﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    public interface IEntradaController
    {
        void Create(EntradaDTO entradaDTO);
        EntradaDTO Read(long id);
        IList<EntradaDTO> ReadAll();
        void Update(EntradaDTO entradaDTO);
        void Delete(long id);
    }
}
