using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejer014;
using Microsoft.Practices.Unity;

namespace ejer014Test
{
    [TestClass]
    public class EntradaControllerIntegracionTest
    {
        private IEntradaController entradaController;

        [TestInitialize]
        public void Initialize()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEntradaController, EntradaController>();
            unityContainer.RegisterType<IEntradaService, EntradaService>();
            unityContainer.RegisterType<IEntradaRepository, EntradaRepository>();
            unityContainer.RegisterType<IEntradaConverter, EntradaConverter>();

            entradaController = unityContainer.Resolve<IEntradaController>();

        }

        [TestMethod]
        public void CreateMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Delete(entradaDTO.Id);
        }

        [TestMethod]
        public void ReadMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Read(entradaDTO.Id);
        }

        [TestMethod]
        public void ReadAllMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.ReadAll();
        }

        [TestMethod]
        public void UpdateMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Update(entradaDTO);
        }
    }
}
