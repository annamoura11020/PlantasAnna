using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantas_Anna_1701185.Classes
{
    public class Plantas
    {
        private int id;
        public int ID { get { return id; } set { id = value; } }
        public string Nome { get; set; }
        public string Caracteristica { get; set; }
        public string Imagem { get; set; }

        public string ObterNome()
        {
            return  Nome;
        }
    }
}
