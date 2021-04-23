using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTAX_5.Repository
{
    class PriceRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<Price> Mapper(List<List<string>> data)
        {
            List<Price> result = new List<Price>();

            foreach(List<string> i in data)
            {
                result.Add(
                    new Price(
                        Convert.ToInt64(i[0]),
                        i[1].Split(' ')[0],
                       Convert.ToDouble(i[2]),
                       Convert.ToInt64(i[3]),
                       Convert.ToInt64(i[4]),
                       Convert.ToInt64(i[5])
                       ));
            }

            return result;
        }

        public List<Price> Search(string sql)
        {
            return Mapper(connection.ExecuteSQL(sql));
        }

        public List<List<string>> Analis(string from, string to)
        {
            return connection.ExecuteSQL(
             "select distinct \"name_org\", min(\"price_for_one\"), max(\"price_for_one\"), sum(\"price_for_one\") / count(\"price_for_one\") " +
             "from \"Price\" p, \"Org\" o " +
             "where extract(YEAR from \"date\") >= " + from + " " +
             "and extract(YEAR from \"date\") <= " + to + " " +
             "and p.\"PK_Org\" = o.\"PK_Org\" " +
             "group by \"name_org\" "
             );    
        }

        public List<List<string>> GetUniqYears()
        {
            return connection.ExecuteSQL(
                "select distinct extract(YEAR from \"date\") as \"year\" from \"Price\" order by \"year\""
                );
        }
        public List<Price> GetAll()
        {
            return Mapper(connection.ExecuteSQL("select * from getlistprice()"));
        }

        public long Add(
            string date,
            double price,
            long org,
            long product,
            long edizm
           )
        {
            connection.ExecuteSQL("call addprice('"+date+"', "
                +price.ToString().Replace(',', '.')
                +", "+org+", "+product+", "+edizm+")");

            List<Price> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    public class Price
    {
        public long id { get; set; }
        public string date { get; set; }
        public double price { get; set; }
        public long org { get; set; }
        public long product { get; set; }
        public long edizm { get; set; }
        

        public Price(long id, string date, double price, long org, long product, long edizm)
        {
            this.id = id;
            this.date = date;
            this.price = price;
            this.org = org;
            this.product = product;
            this.edizm = edizm;
        }
    }
}
