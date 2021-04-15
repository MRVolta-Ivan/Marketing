using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTAX_5.Repository
{
    class OrgRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<Org> Mapper(List<List<string>> data)
        {
            List<Org> result = new List<Org>();

            foreach(List<string> i in data)
            {
                result.Add(
                    new Org(
                        Convert.ToInt64(i[0]),
                        i[1],
                        i[2],
                        i[3]));
            }

            return result;
        }

        public List<Org> GetAll()
        {
            return Mapper(connection.ExecuteSQL("select * from getlistorg()"));
        }

        public long Add(
            string shifr,
            string name,
            string adress)
        {
            connection.ExecuteSQL("call addorg('"+shifr+"','"+name+"','"+adress+"')");

            List<Org> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    class Org
    {
        public long id;
        public string shifr;
        public string name;
        public string adress;

        public Org(long id, string shifr, string name, string adress)
        {
            this.id = id;
            this.shifr = shifr;
            this.name = name;
            this.adress = adress;
        }
    }
}
