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
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public bool Protegido { get; set; }

        public string ConectionString 
        {
            get
            {
                var dados = JsonConvert.DeserializeObject<Config>(File.OpenWrite("Config.json").ToString());
                if (dados.Protegido)
                {
                    return "Persist Security Info=False;User ID=sa;pwd=dba1@alpha;Initial Catalog=" + dados.Banco + ";Data Source=" + dados.Servidor;
                }
                else
                {
                    return "Persist Security Info=False;User ID=sa;pwd=;Initial Catalog=" + dados.Banco + ";Data Source=" + dados.Servidor;

                }
            }
        }

    }


}
