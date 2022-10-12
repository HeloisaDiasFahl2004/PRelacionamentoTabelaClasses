using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRelacionamentoTabelaClasses
{
    internal class Car
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Team")]//tabela Team
        public int TeamId { get; set; }//propriedade que referencia a chave primária
        public virtual Team Team { get; set; }//1 equipe sempre tem 2 carros; virtual permite a sobescrição do objeto

        public override string ToString()
        {
            return "Name: "+this.Name+"\nEquipe: "+this.Team.Name; 
        }
    }
}
