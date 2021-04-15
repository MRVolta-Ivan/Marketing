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


    class EdIzm
    {
        public long id;
        public string shifr;
        public string name;

        public EdIzm(long id, string shifr, string name)
        {
            this.id = id;
            this.shifr = shifr;
            this.name = name;
        }
    }
}
