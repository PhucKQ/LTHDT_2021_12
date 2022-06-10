using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruTamGiac : ILuuTruTamGiac
    {
        public TamGiac DocTamGiac()
        {
            StreamReader file = new StreamReader
                ("../DAL/tamgiac.json");
            string jsonString = file.ReadToEnd();
            file.Close();

            var result = JsonConvert.
                DeserializeObject
                <TamGiac>(jsonString);

            return result;
        }

        public void LuuTamGiac(TamGiac t)
        {
            StreamWriter writer = new StreamWriter
                ("../DAL/tamgiac.json");

            string jsonString = JsonConvert.
                SerializeObject(t);
            writer.Write(jsonString);

            writer.Close();
        }
    }
}
