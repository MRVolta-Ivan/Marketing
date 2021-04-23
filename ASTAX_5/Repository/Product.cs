using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTAX_5.Repository
{
    class ProductRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<Product> Mapper(List<List<string>> data)
        {
            List<Product> result = new List<Product>();

            foreach(List<string> i in data)
            {
                result.Add(
                    new Product(
                        Convert.ToInt64(i[0]),
                        i[1],
                        i[2]));
            }

            return result;
        }

        public List<Product> GetAll()
        {
            return Mapper(connection.ExecuteSQL("select * from getlistproduct()"));
        }

        public List<Product> GetProductIO()
        {
            return Mapper(connection.ExecuteSQL("select distinct o.* from \"Product\" o, \"Input_output\" i where o.\"PK_Product\" = i.\"PK_product\""));
        }

        public List<Product> GetProductIO2()
        {
            return Mapper(connection.ExecuteSQL("select distinct o.* from \"Product\" o, \"Price\" i where o.\"PK_Product\" = i.\"PK_Product\""));
        }

        public Product GetById(long id)
        {
            return Mapper(connection.ExecuteSQL("select * from \"Product\" where \"PK_Product\" = "+id+""))[0];
        }

        public long Add(
            string shifr,
            string name)
        {
            connection.ExecuteSQL("call addproduct('"+shifr+"','"+name+"')");

            List<Product> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    public class Product
    {
        public long id { get; set; }
        public string shifr { get; set; }
        public string name { get; set; }

        public Product(long id, string shifr, string name)
        {
            this.id = id;
            this.shifr = shifr;
            this.name = name;
        }
    }
}
