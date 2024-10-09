using KPZ_Lab2.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.Model.Models;

namespace KPZ_Lab2.Models
{

    [Serializable]
    public class DataModel 
    {
        public IEnumerable<Account> Accounts { get; set; }

        public static string DataPath = @"../SerializationTest.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
             return DataSerializer.DeserializeData(DataPath);
            }
            return new DataModel();
        }

        public  void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }

        public DataModel()
        {
            Accounts = new List<Account>();
        }
    }
}
