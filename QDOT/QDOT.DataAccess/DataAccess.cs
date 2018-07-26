using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using QDOT.DataAccess.Interface;
using QDOT.Model;

namespace QDOT.DataAccess
{
    public class DataAccess : IDataAccess<List<Developer>>, IDisposable
    {
        public void Dispose()
        {
            
        }

        public List<Developer> GetAll()
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Developer>>(File.ReadAllText(@"developers.json"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public List<Developer> GetFiltered(List<Developer> developers)
        {
            try
            {
                List<Developer> filtered = new List<Developer>();
                filtered.AddRange(developers.FindAll(c => c.Skills.Exists(p => p.Level >= 8)));     
                foreach (Developer d in filtered)
                {   
                    d.Skills.RemoveAll(c => c.Level < 8);
                }
                return filtered;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }
    }
}
