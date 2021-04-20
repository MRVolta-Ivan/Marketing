using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTAX_5.Repository
{
    class InputOutputRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<InputOutput> Mapper(List<List<string>> data)
        {
            List<InputOutput> result = new List<InputOutput>();

            foreach(List<string> i in data)
            {
                result.Add(
                    new InputOutput(
                        Convert.ToInt64(i[0]),
                        i[1],
                        i[2],
                        Convert.ToInt64(i[3]),
                        Convert.ToDouble(i[4]),
                        Convert.ToInt64(i[5]),
                        Convert.ToInt64(i[6]),
                        Convert.ToInt64(i[7])));
            }

            return result;
        }

        public List<InputOutput> GetAll()
        {
            return Mapper(connection.ExecuteSQL("select * from getlistinputoutput()"));
        }

        public long Add(
            string date,
            string number,
            long count,
            double price,
            long org,
            long product,
            long edizm)
        {
            connection.ExecuteSQL("call addinputoutput('"+date+"', '"+number+"',"
                +count+
                ", " + price.ToString().Replace(',', '.') + ", "+org+
                ", "+product+", "+edizm+")");

            List<InputOutput> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    public class InputOutput
    {
        public long id;
        public string date;
        public string number;
        public long count;
        public double price;
        public long org;
        public long product;
        public long edizm;

        public InputOutput(long id, string date, string number, long count, double price, long org, long product, long edizm)
        {
            this.id = id;
            this.date = date;
            this.count = count;
            this.price = price;
            this.org = org;
            this.product = product;
            this.edizm = edizm;
            this.number = number;
        }
    }
}
