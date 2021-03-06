using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTAX_5.Repository
{
    class EdIzmRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<EdIzm> Mapper(List<List<string>> data)
        {
            List<EdIzm> result = new List<EdIzm>();

            foreach(List<string> i in data)
            {
                result.Add(
                    new EdIzm(
                        Convert.ToInt64(i[0]),
                        i[1],
                        i[2]));
            }

            return result;
        }

        public List<EdIzm> GetAll()
        {
            return Mapper(connection.ExecuteSQL("select * from getlistedizm()"));
        }

        public EdIzm GetById(long id)
        {
            return Mapper(connection.ExecuteSQL("select * from \"Ed_izm\" where \"PK_Ed_izm\" = "+id+""))[0];
        }

        public long Add(
            string shifr,
            string name)
        {
            connection.ExecuteSQL( "call addedizm('"+shifr+"','"+name+"')");

            List<EdIzm> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }

    }


    public class EdIzm
    {
        public long id { get; set; }
        public string shifr { get; set; }
        public string name { get; set; }

        public EdIzm(long id, string shifr, string name)
        {
            this.id = id;
            this.shifr = shifr;
            this.name = name;
        }
    }
}
