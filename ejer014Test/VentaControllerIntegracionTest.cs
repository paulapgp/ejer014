using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejer014;
using Microsoft.Practices.Unity;

namespace ejer014Test
{
    [TestClass]
    public class VentaControllerIntegracionTest
    {
        private IVentaController ventaController;
        
        [TestInitialize]
        public void Initialize()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IVentaRepository, VentaRepository>();
            unityContainer.RegisterType<IVentaService, VentaService>();
            unityContainer.RegisterType<IVentaConverter, VentaConverter>();
            unityContainer.RegisterType<IVentaController, VentaController>();

            ventaController = unityContainer.Resolve<IVentaController>();

        }

        [Ignore]
        [TestMethod]
        public void CreateMethod()
        {
            VentaDTO ventaDTO = new VentaDTO();
            ventaController.Create(ventaDTO);
        }
    }
}
