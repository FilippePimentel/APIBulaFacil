using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace APIBulaFacil.Presentation.Util
{
    public class ValidationUtil
    {
        public static Hashtable GetErrors(ModelStateDictionary ModelState)
        {
            //declarando um Hashtable
            var erros = new Hashtable();
            //percorrendo cada posição do ModelState
            foreach (var item in ModelState)
            {
                //verificando se contem erros de validação
                if (item.Value.Errors.Count > 0)
                {
                    erros[item.Key] = item.Value.Errors.Select
                    (e => e.ErrorMessage).ToList();
                }
            }
            //retornando
            return erros;
        }
    }
}