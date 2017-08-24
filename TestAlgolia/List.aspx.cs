using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestAlgolia.Model;

namespace TestAlgolia
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Product> GetCategories()
        {
            var db = new ADBContext();
            if (db.Products.Count() == 0)
            {
                var getproduct = new ProductInitializer();

                db.Products.AddRange(getproduct.GetProducts());
                db.SaveChanges();
            }
            
            IQueryable<Product> query = db.Products;
            return query;
        }
    }
}