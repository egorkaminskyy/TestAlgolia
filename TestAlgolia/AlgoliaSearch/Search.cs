using Algolia.Search;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAlgolia.Model;

namespace TestAlgolia.AlgoliaSearch
{
    public class Search
    {
        private AlgoliaClient client;
        private ADBContext db;
        public Search()
        {
            client = new AlgoliaClient("H32KJL7TN3", "ded83594a24bb787256ec5c09acfd98d");
            db = new ADBContext();
            this.AddIndexes();
        }

        private void AddIndexes()
        {
            var products = db.Products;



            Index index = client.InitIndex("products");
            index.SetSettings(JObject.Parse(@"{""searchableAttributes"":[""Name"", ""Prise""]}"));
            List<JObject> objs = new List<JObject>();
            foreach(var item in products)
            {
                
                objs.Add(JObject.Parse(item.ToString()));
            }
            var res = index.AddObjects(objs);
            System.Diagnostics.Debug.WriteLine(res);
        }


        


    }
}