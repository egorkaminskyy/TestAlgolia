using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAlgolia.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prise { get; set; }


        public override string ToString()
        {
            
            return  @"{'objectID':'"+Id+"\', \'Name':\'"+Name+ "\', \'Prise':\'" + Prise + @"'}";
        }
    }

     
}