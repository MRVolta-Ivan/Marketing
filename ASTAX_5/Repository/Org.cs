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
                        i[2]
                        ));
            }

            return result;
        }

        public List<Org> GetAll()
        {
            return Mapper(connection.ExecuteSQL("select * from getlistorg()"));
        }

        public List<Org> GetOrgIO()
        {
            return Mapper(connection.ExecuteSQL(
                "select distinct o.* from \"Org\" o, \"Input_output\" i where o.\"PK_Org\" = i.\"PK_Org\""));
        }

        public List<Org> GetOrgIO2()
        {
            return Mapper(connection.ExecuteSQL(
                "select distinct o.* from \"Org\" o, \"Price\" i where o.\"PK_Org\" = i.\"PK_Org\""));
        }

        public Org GetById(long id)
        {
            return Mapper(connection.ExecuteSQL("select * from \"Org\" where \"PK_Org\" = "+id+""))[0];
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

    public class Org
    {
        public long id { get; set; }
        public string shifr { get; set; }
        public string name { get; set; }
        

        public Org(long id, string shifr, string name)
        {
            this.id = id;
            this.shifr = shifr;
            this.name = name;
            
        }
    }
}
