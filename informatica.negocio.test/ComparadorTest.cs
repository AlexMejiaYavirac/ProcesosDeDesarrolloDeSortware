using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace informatica.negocio.test
{
    [TestClass]
    public class ComparadorTest
    {
        [TestMethod]
        public void ObtnerMenor()
        {
     //Triple AAA => Arrange,Act, Assert

        //Organizar Datos -- Arrange 
        var primerElemento = 56;
        var segundoElemento = 20;
        var esperado = 20;
        
        //Ejecute -- Act
        Comparador comparador =  new Comparador();
        int actual = comparador.ObtnerMenor(primerElemento,segundoElemento);

        //Comprobar -- Assert

        Assert.AreEqual(esperado,actual);
        
        
        }
    }
}
