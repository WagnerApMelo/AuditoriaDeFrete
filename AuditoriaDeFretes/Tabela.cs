using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriaDeFretes
{
    public class Tabela
    {

        public string operacao { get; set; }
        public string tipoFrete { get; set; }
        public string tipoTaxa { get; set; } 
        public int codigoTransportadora { get; set; }
        public string codigoVeiculo { get; set; }
        public string cnpjEmitente { get; set; }
        public string taxJurCode { get; set; }
        public int nivelDestinatario { get; set; }
        public string codigoDestino { get; set; }
        public string cepDe { get; set; }
        public string cepAte { get; set; }
        public string unidadeMedida { get; set; }
        public double faixaDe { get; set; }
        public double faixaAte { get; set; }
        public string unidadeCalculo { get; set; }
        public double valor { get; set; }
        public double valorMinimo { get; set; }
        public DateTime inicioVigencia { get; set; }
        public DateTime fimVigencia { get; set; }
        public ListaTabela Lista { get; set; }

    }
}
