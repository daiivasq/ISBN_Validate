using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidationISBN
{
    public class ISBN
    {
       
        public static string ImputValidation(string text)
        {
            bool condicion;
            string valid = "VALIDO";
            string invalid = "INVALIDO";
            string result = "";

            if (text is null)
            {
                throw new ArgumentNullException();
                condicion = true;
            }
            else if (text.Length == 0 || text.Length > 13 || text.Length < 10 ) condicion = true;
            else if(text.Length == 13 || text.Length == 10) condicion = false;
            else condicion = false;

            if (condicion == true) result = invalid;           
            else if (condicion == false) result = valid;
            return result;
        }

        public static string ValidateISBN(string text)
        {
            string valid = "VALIDO";
            string invalid = "INVALIDO";
            string validISBN = "ISBN VALIDO";
            if (ImputValidation(text) == invalid) text = invalid;
            if (ImputValidation(text) == valid)
            {
                if (text.Length == 10)
                {
                    int[] isbn = text.ToCharArray().Select(i => i == 'X' ? 10 : int.Parse(i.ToString())).ToArray();
                    int total = 0;
                    for (int i = 0; i < 10; i++) total += isbn[i] * (10 - i);
                    
                    if(total % 11 == 0)text = validISBN;
                    else text = invalid;
                    
                }
                if (text.Length == 13)
                {
                    int[] isbn = text.ToCharArray().Select(i => i == 'X' ? 13 : int.Parse(i.ToString())).ToArray();
                    int total = 0;
                    for (int i = 0; i < 12; i++)total += isbn[i] * (i % 2 == 1 ? 3 :1);
                    
                    if (total % 10 == 0)text = validISBN; 
                    else text = invalid;
                }
            }
            return text;
        }

    }
}
