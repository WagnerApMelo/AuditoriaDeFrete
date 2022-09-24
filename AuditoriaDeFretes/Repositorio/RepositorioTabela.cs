using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriaDeFretes
{
    public class RepositorioTabela
    {
        private static readonly string nomeArquivoCSV = "Repositorio\\PVM.csv";

        public ListaTabela imprimir;

        public RepositorioTabela()
        {
            var tabelaGeral = new List<Tabela>();

            using (var file = File.OpenText(RepositorioTabela.nomeArquivoCSV))
            {

                while (!file.EndOfStream)
                {
                    var tarifa = file.ReadLine();

                    if (string.IsNullOrEmpty(tarifa))
                    {
                        continue;
                    }

                    var linha = tarifa.Split(';');
                    var tabela = new Tabela()
                    {
                        operacao = linha[0],
                        tipoFrete = linha[1],
                        tipoTaxa = linha[2],
                        //codigoTransportadora = Convert.ToInt32(linha[3]),
                        //codigoVeiculo = linha[4],
                        //cnpjEmitente = linha[5],
                        //taxJurCode = linha[6],
                        //nivelDestinatario = Convert.ToInt32(linha[7]),
                        //codigoDestino = linha[8],
                        //cepDe = linha[9],
                        //cepAte = linha[10],
                        //unidadeMedida = linha[11],
                        //faixaDe = Convert.ToDouble(linha[12]),
                        //faixaAte = Convert.ToDouble(linha[13]),
                        //unidadeCalculo = linha[14],
                        //valor = Convert.ToDouble(linha[15]),
                        //valorMinimo = Convert.ToDouble(linha[16]),
                        //inicioVigencia = Convert.ToDateTime(linha[17]),
                        //fimVigencia = Convert.ToDateTime(linha[18]),
                    };

                    tabelaGeral.Add(tabela);

                }

                
            }

            imprimir = new ListaTabela(tabelaGeral.ToArray());


        }

        public ListaTabela Imprimir => imprimir;

       

    }
 
}
