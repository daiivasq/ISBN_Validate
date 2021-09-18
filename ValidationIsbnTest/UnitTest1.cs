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
        //ISBN ---> null               ---->  ArgumentNullException ---> DONE
        //ISBN ---> ""                 ---->  INVALIDO              ---> DONE

        //ISBN ---> 12345678901234      ---->  INVALIDO // si es mayor a 13 numeros  ----> DONE
        //ISBN ---> 123456789          ---->  INVALIDO // // si es menor a 10 numeros  ----> DONE

        //ISBN ---> 1234567890         ---->  VALIDO // CANTIDAD EXACTA DE 10 DIGITOS ----> DONE 
        //ISBN ---> 1234567890123      ---->  VALIDO // CANTIDAD EXACTA DE 13 DIGITOS ----> DONE

        //ISBN ----> 0716703440      -----> ISBN VALIDO -----> DONE
        //ISBN ----> 9780716703440   -----> ISBN VALIDO ------> DONE
        /// </summary>


        [Test]

        public void MethodWithNullArgumentException()
        {
            Assert.Catch<ArgumentNullException>(() => ISBN.ImputValidation(null));
        }

        [Test]

        public void MethodWithImputIsEmpty()
        {
            string res = ISBN.ImputValidation("");
            string exp = "INVALIDO";
            Assert.AreSame(res, exp);

        }
        [Test]

            public void MethodWithImputIsMax13Character()
            {
                string res = ISBN.ImputValidation("12345678901234");
                string exp = "INVALIDO";
                Assert.AreSame(res, exp);
            }

        [Test]

        public void MethodWithImputIsMinor10Character()
        {
            string res = ISBN.ImputValidation("123456789");
            string exp = "INVALIDO";
            Assert.AreSame(res, exp);
        }

        [Test]

        public void MethodWithImputIsEqueal10Character()
        {
            string res = ISBN.ImputValidation("1234567890");
            string exp = "VALIDO";
            Assert.AreSame(res, exp);
        }

        [Test]

        public void MethodWithImputIsEqueal13Character()
        {
            string res = ISBN.ImputValidation("1234567890123");
            string exp = "VALIDO";
            Assert.AreSame(res, exp);
        }

        [Test]

        public void MethodWithISBN10IsValid()
        {
            string res = ISBN.ValidateISBN("0716703440");
            string exp = "ISBN VALIDO";
            Assert.AreSame(res, exp);
        }

        [Test]

        public void MethodWithISBN13IsValid()
        {
            string res = ISBN.ValidateISBN("9780716703440");
            string exp = "ISBN VALIDO";
            Assert.AreSame(res, exp);
        }



    }
}