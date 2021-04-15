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

    class Product
    {
        public long id;
        public string shifr;
        public string name;

        public Product(long id, string shifr, string name)
        {
            this.id = id;
            this.shifr = shifr;
            this.name = name;
        }
    }
}
