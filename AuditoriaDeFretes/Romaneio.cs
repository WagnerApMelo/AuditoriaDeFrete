using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriaDeFretes
{
    public class Romaneio
    {
        public string operacao { get; private set; }
        public double romaneio { get; private set; }
        public double delivery { get; private set; }
        public Transportadora transportadora { get; set; }
        public string tipoFrete { get; set; }
        public DateOnly dataColeta { get; set; }
        public string veiculo { get; set; }


    }
}
