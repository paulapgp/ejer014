using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    public class EntradaController : IEntradaController
    {
        private IEntradaConverter entradaConverter;
        private IEntradaService entradaService;
        public EntradaController(IEntradaConverter _entradaConverter, IEntradaService _entradaService)
        {
            this.entradaConverter = _entradaConverter;
            this.entradaService = _entradaService;
        }

        public void Create(EntradaDTO entradaDTO)
        {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Create(entrada);
        }

        public void Delete(long id)
        {
            entradaService.Delete(id);
        }

        public EntradaDTO Read(long id)
        {
            Entrada entrada = entradaService.Read(id);
            EntradaDTO entradaDTO = entradaConverter.EntityToDTO(entrada);
            return entradaDTO;
        }

        public IList<EntradaDTO> ReadAll()
        {
            IList<EntradaDTO> listaResultado = new List<EntradaDTO>();
            IList<Entrada> listaEntrada = entradaService.ReadAll();

            foreach (Entrada e in listaEntrada)
            {
                EntradaDTO entradaDTO = entradaConverter.EntityToDTO(e);
                listaResultado.Add(entradaDTO);
            }

            return listaResultado;
        }

        public void Update(EntradaDTO entradaDTO)
        {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Update(entrada);

        }
    }
}
