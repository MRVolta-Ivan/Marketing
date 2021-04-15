﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTAX_5.Repository
{
    class TypeSegmentRepository
    {

        DBConnection connection = DBConnection.instance;

        private List<TypeSegment> Mapper(List<List<string>> data)
        {
            List<TypeSegment> result = new List<TypeSegment>();

            foreach(List<string> i in data)
            {
                result.Add(
                    new TypeSegment(
                        Convert.ToInt64(i[0]),
                        i[1],
                        i[2]));
            }

            return result;
        }

        public List<TypeSegment> GetAll()
        {
            return Mapper(connection.ExecuteSQL("select * from getlisttypesegment()"));
        }

        public long Add(
            string shifr, 
            string name)
        {
            connection.ExecuteSQL("call addtypesegment('"+shifr+"','"+name+"')");

            List<TypeSegment> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    class TypeSegment
    {
        public long id;
        public string shifr;
        public string name;

        public TypeSegment(long id, string shifr, string name)
        {
            this.id = id;
            this.shifr = shifr;
            this.name = name;
        }
    }
}