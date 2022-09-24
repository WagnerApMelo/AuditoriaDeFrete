using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriaDeFretes
{
    public class ListaTabela
    {
        private List<Tabela> _tabela;

        public ListaTabela(params Tabela[] tabelas)
        {
            _tabela = tabelas.ToList();
            _tabela.ForEach(l => l.Lista = this);
        }
        public IEnumerable<Tabela> Tabelas
        {
            get { return _tabela; }
        }
        public override string ToString()
        {
            var linhas = new StringBuilder();
            linhas.AppendLine("=========");
            foreach (var tabela in Tabelas)
            {
                linhas.AppendLine(tabela.ToString());
            }
            return linhas.ToString();
        }
    }
}
