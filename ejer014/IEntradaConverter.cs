﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    public interface IEntradaConverter
    {
        EntradaDTO EntityToDTO(Entrada entrada);
        Entrada DTOToEntity(EntradaDTO entradaDTO);
    }
}
