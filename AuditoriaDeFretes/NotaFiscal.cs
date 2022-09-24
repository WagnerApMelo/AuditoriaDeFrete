using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriaDeFretes
{
    public class NotaFiscal
    {
        public string cnpjEmitente { get; private set; }
        public int numero { get; private set; }
        public int serie { get; private set; }
        public double delivery { get; private set; }
        public double quantidade { get; private set; }
        public string unidade { get; private set; }
        public double peso { get; private set; }
        public double valorDaNota { get; private set; }
        public string municipio { get; private set; }
        public string uf { get; private set; }
        public string cepOrigem { get; private set; }
        public string cepDestino { get; private set; }

    }
}
