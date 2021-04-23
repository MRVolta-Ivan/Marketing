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
                        i[1].Split(' ')[0],
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

        public List<List<string>> GetUniqNumDoc()
        {
            return connection.ExecuteSQL(
                "select distinct \"number_doc\" from \"Input_output\"");

        }

        public List<List<string>> GetUniqYears()
        {
            return connection.ExecuteSQL(
                "select distinct extract(YEAR from \"date\") as \"year\" from \"Input_output\" order by \"year\""
                );
        }

        public List<InputOutput> GetFromToDate(string from, string to)
        {
            return Mapper(connection.ExecuteSQL(
                "select * from \"Input_output\" where extract(YEAR from \"date\") >= " + from + " and extract(YEAR from \"date\") <= " + to + ""));
        }

        public string GetSumSegmentProduct(string fromdate, string todate, long product, long segment)
        {
            return connection.ExecuteSQL(
                "select distinct sum(\"price_for_one\" * \"count\") from (select * from \"Input_output\" "+

              "where extract(YEAR from \"date\") >= "+fromdate+" "+

              "and extract(YEAR from \"date\") <= "+todate+") as io, "+
			  "\"Type_segment\" ts, \"Segment\" s "+
              "where io.\"PK_product\" = "+product+" "+

              "and io.\"PK_Org\" = s.\"PK_Org\""+

              "and s.\"PK_Type_segment\" = ts.\"PK_Type_segment\""+

              "and ts.\"PK_Type_segment\" = "+segment+"")[0][0];
        }

        public List<InputOutput> Search(string sql)
        {
            return Mapper(connection.ExecuteSQL(sql));
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
