using NUnit.Framework;
using System;
using ValidationISBN;

namespace ValidationIsbnTest
{
    public class Tests
    {
        /// <summary>
        /// /////
      ///  Red -> Una SOLA PRUEBA que falle
     ///   Green -> Hacer pasar la UNICA prueba que esta fallando
     ///   Refactor -> Mejorar la mantenibiliad del codigo
        /// PRUEBAS UNITARIAS
        /// 
        //ISBN ---> null               ---->  ArgumentNullException 
        //ISBN ---> ""                 ---->  INVALIDO

        //ISBN ---> 1234567890123      ---->  INVALIDO // si es mayor a 13 numeros
        //ISBN ---> 123456789          ---->  INVALIDO // // si es menor a 10 numeros

        //ISBN ---> 1234567890         ---->  VALIDO // CANTIDAD EXACTA DE 10 DIGITOS
        //ISBN ---> 1234567890123      ---->  VALIDO // CANTIDAD EXACTA DE 13 DIGITOS

        //ISBN ----> 0716703440      -----> ISBN VALIDO 
        //ISBN ----> 9780716703440   -----> ISBN VALIDO
        /// </summary>




    }
}