using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QDOT.DataAccess.Interface;
using QDOT.Model;

namespace QDOT.DataAccess
{
    public class DataAccess : IDataAccess<JArray>, IDisposable
    {
        public void Dispose()
        {
            
        }

        public JArray GetAll()
        {
            try
            {
                var json = JArray.Parse(File.ReadAllText(@"developers.json"));
                return json;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public JArray GetFiltered()
        {
            try
            {
                List<Developer> all = JsonConvert.DeserializeObject<List<Developer>>(File.ReadAllText(@"developers.json"));
                List<Developer> filtered = new List<Developer>();

                filtered.AddRange(all.FindAll(c => c.Skills.Exists(p => p.Level >= 8)));

                foreach (Developer d in filtered)
                {   
                    d.Skills.RemoveAll(c => c.Level < 8);
                }

                var json = JArray.Parse(JsonConvert.SerializeObject(filtered));
                return json;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
