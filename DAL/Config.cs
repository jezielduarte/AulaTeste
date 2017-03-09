using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace DAL
{
    public class Config
    {
        public string servidor { get; set; }
        public string banco { get; set; }
        public bool Protegido { get; set; }

        public Config criarconfig()
        {
            return JsonConvert.DeserializeObject<Config>(File.OpenWrite("Config.json").ToString());
        }
    }


}
