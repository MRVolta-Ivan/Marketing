using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTAX_5.Repository
{
    class SegmentRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<Segment> Mapper(List<List<string>> data)
        {
            List<Segment> result = new List<Segment>();

            foreach(List<string> i in data)
            {
                result.Add(
                    new Segment(
                        Convert.ToInt64(i[0]),
                        Convert.ToInt64(i[1]),
                        Convert.ToInt64(i[2])));
            }

            return result;
        }

        public List<Segment> GetAll()
        {
            return Mapper(connection.ExecuteSQL("select * from getlistsegment()"));
        }

        public long Add(
            long org,
            long typesegment)
        {
            connection.ExecuteSQL("call addsegment("+org+","+typesegment+")");

            List<Segment> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    class Segment
    {
        public long id;
        public long org;
        public long typesegment;

        public Segment(long id, long org, long typesegment)
        {
            this.id = id;
            this.org = org;
            this.typesegment = typesegment;
        }
    }
}
