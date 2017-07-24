using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    public class EntradaRepository : IEntradaRepository
    {
        private IList<Entrada> listaEntradas = new List<Entrada>();

        public void Create(Entrada entrada)
        {
            if (entrada != null)
            {
                listaEntradas.Add(entrada);
            }
        }

        public void Delete(long id)
        {
            Entrada entrada = new Entrada();
            entrada.Id = id;
            listaEntradas.Remove(entrada);
        }

        public Entrada Read(long id)
        {
            return null;
            //return listaEntradas.ElementAt();
        }

        public IList<Entrada> ReadAll()
        {
            return listaEntradas;
        }

        public void Update(Entrada entrada)
        {
            throw new NotImplementedException();
        }
    }
}
