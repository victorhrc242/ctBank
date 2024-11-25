using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctbanks.Repositors.DTO
{
    [Table("ContaPoupanca")]
    public class contapopancaDTO
    {
      public double TaxaDeJuros { get; set; }
             public int  IdConta { get; set; }
    }
}
