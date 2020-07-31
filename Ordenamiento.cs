using System;
using System.Collections.Generic;

namespace informatica.negocio.test
{
    internal class Ordenamiento
    {
        internal List<int> Ordenar(int primero, int segundo, int tercero)
        {
            var resultados = new List<int>();


            resultados.Add(primero);
            resultados.Add(segundo);
            resultados.Add(tercero);
            resultados.Sort();


            /*
                        if (primero <= segundo)
                        {
                            if (primero <= tercero)
                            {
                                resultados.Add(primero);
                                if (segundo <= tercero)
                                {
                                    resultados.Add(segundo);
                                    resultados.Add(tercero);
                                }
                                else
                                {
                                    resultados.Add(tercero);
                                    resultados.Add(segundo);

                                }
                            }
                            else
                            {
                                resultados.Add(tercero);
                                if (segundo <= primero)
                                {
                                    resultados.Add(segundo);
                                    resultados.Add(primero);
                                }
                                else
                                {
                                    resultados.Add(primero);
                                    resultados.Add(segundo);

                                }
                            }
                        }
                        else
                        {
                            if (segundo <= tercero)
                            {
                                resultados.Add(segundo);
                                if (primero <= tercero)
                                {
                                    resultados.Add(primero);
                                    resultados.Add(tercero);
                                }
                                else
                                {
                                    resultados.Add(tercero);
                                    resultados.Add(primero);

                                }
                            }
                            else
                            {
                                resultados.Add(tercero);
                                if (primero <= segundo)
                                {
                                    resultados.Add(primero);
                                    resultados.Add(segundo);
                                }
                                else
                                {
                                    resultados.Add(segundo);
                                    resultados.Add(primero);

                                }
                            }
                        }
                        
                        return resultados;
            */
            return resultados;




        }

        public List<Estudiante> Ordenar(Estudiante persona1, Estudiante persona2, Estudiante persona3)
        {

            var resultados = new List<Estudiante>(); 
            resultados.Add(persona1);
            resultados.Add(persona2);
            resultados.Add(persona3);
            resultados.Sort();
        //QuickSort();
            return resultados;
        }
    }


}