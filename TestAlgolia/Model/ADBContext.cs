using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestAlgolia.Model
{

    public class ADBContext:DbContext
    {
        public ADBContext():base("Adb")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}