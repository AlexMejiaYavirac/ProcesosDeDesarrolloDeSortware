using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace informatica.negocio.test
{
    [TestClass]
   public class OrdenamientoTest
   {
       [TestMethod]
       public void TresElementos()
       {

           var primero = 45;
           var segundo = 23;
           var tercero = 15;

           var esperado = 15;
           var esperado2 = 23;

        Ordenamiento ordenamiento = new Ordenamiento();
        List<int> esperados = ordenamiento.Ordenar(primero,segundo,tercero);

        Assert.AreEqual(esperado,esperados[0]);
        Assert.AreEqual(esperado2,esperados[1]);
    
       }


       [TestMethod]

        public void OrdenarPersonas(){

            var persona1 = new Estudiante();
            persona1.Nombre = "Alexander";
            persona1.Apellido = "Mejia";
            persona1.Nacimiento = new DateTime(1998,5,20);

            var persona2 = new Estudiante();
            persona2.Nombre = "Jose";
            persona2.Apellido = "Mostacho";
            persona2.Nacimiento = new DateTime(1998,6,10);

            var persona3 = new Estudiante();
            persona3.Nombre = "Gorky";
            persona3.Apellido = "Estrella";
            persona3.Nacimiento = new DateTime(2000,5,20);

            
            var esperado1 = "Alexander";
            var esperado2 = "Gorky";
            var esperado3 = "Jose";
                
            Ordenamiento ordenamiento = new Ordenamiento();
            List<Estudiante> actual = ordenamiento.Ordenar(persona1,persona2,persona3);

            Assert.AreEqual(esperado1,actual[0].Nombre);
            Assert.AreEqual(esperado2,actual[1].Nombre);
            Assert.AreEqual(esperado3,actual[2].Nombre);



        }

        

   }
}
